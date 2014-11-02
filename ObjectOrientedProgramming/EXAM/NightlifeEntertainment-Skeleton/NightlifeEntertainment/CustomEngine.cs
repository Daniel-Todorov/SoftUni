namespace NightlifeEntertainment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CustomEngine : CinemaEngine
    {
        protected override void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "venue":
                    this.ExecuteInsertVenueCommand(commandWords);
                    break;
                case "performance":
                    this.ExecuteInsertPerformanceCommand(commandWords);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "cinema":
                    var cinema = new Cinema(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(cinema);
                    break;
                case "opera":
                    var opera = new OperaHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportsHall = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sportsHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concertHall);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "movie":
                    var venueMovie = this.GetVenue(commandWords[5]);
                    var movie = new Movie(commandWords[3], decimal.Parse(commandWords[4]), venueMovie, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(movie);
                    break;
                case "theatre":
                    var venueTheatre = this.GetVenue(commandWords[5]);
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venueTheatre, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var venueConcert = this.GetVenue(commandWords[5]);
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venueConcert, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }
                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            //<name>: <tickets_sold> ticket(s), total: $<total_price>
            //Venue: <venue_name> (<venue_location>)
            //Start time: <start_time>

            var performance = this.GetPerformance(commandWords[1]);

            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0}: {1} ticket(s), total: ${2:0.00}",
                performance.Name,
                performance.Tickets.Count(t => t.Status == TicketStatus.Sold),
                performance.Tickets.Where(t => t.Status == TicketStatus.Sold).Sum(t => t.Price)));
            result.AppendLine(string.Format("Venue: {0} ({1})", performance.Venue.Name, performance.Venue.Location));
            result.Append(string.Format("Start time: {0}", performance.StartTime));

            this.Output.AppendLine(result.ToString());
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            //find conCERt 1.08.2014 14:30:00

            //Search for "<phrase>"
            //Performances:
            //-<performance_name>
            //-<performance_name>
            //...
            //Venues:
            //-<venue_name>
            //--<performance_name>
            //--<performance_name>
            //-<venue_name>
            //-<venue_name>
            //--<performance_name>
            //--<performance_name>

            string lowercasedSearchWord = commandWords[1].ToLower();
            DateTime searchedDate = DateTime.Parse(commandWords[2] + " " + commandWords[3]);
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Search for \"{0}\"", commandWords[1]));

            var matchingPerformances = GetMatchingOrderedPerformances(this.Performances, lowercasedSearchWord, searchedDate);
            //var matchingPerformances = this.Performances
            //    .Where(p => p.Name.ToLower().Contains(lowercasedSearchWord)
            //        && p.StartTime >= searchedDate)
            //    .OrderBy(p => p.StartTime)
            //    .ThenByDescending(p => p.BasePrice)
            //    .ThenBy(p => p.Name)
            //    .ToList();

            result.AppendLine("Performances:");

            if (matchingPerformances.Count > 0)
            {
                foreach (var perf in matchingPerformances)
                {
                    result.AppendLine(string.Format("-{0}", perf.Name));
                }
            }
            else
            {
                result.AppendLine("no results");
            }

            result.AppendLine("Venues:");

            var matchingVenues = this.Venues
                .Where(v => v.Name.ToLower().Contains(lowercasedSearchWord))
                .OrderBy(v => v.Name)
                .ToList();

            if (matchingVenues.Count > 0)
            {
                foreach (var venue in matchingVenues)
                {
                    result.AppendLine(string.Format("-{0}", venue.Name));

                    var performancesInVenue = this.Performances.Where(p => p.Venue.Name.Equals(venue.Name)).ToList();

                    if (performancesInVenue.Count > 0)
                    {
                        var matchingPerformancesInVenue = GetMatchingOrderedPerformances(performancesInVenue, string.Empty, searchedDate);

                        if (matchingPerformancesInVenue.Count > 0)
                        {
                            foreach (var perf in matchingPerformancesInVenue)
                            {
                                result.AppendLine(string.Format("--{0}", perf.Name));
                            }
                        }
                    }
                }
            }
            else
            {
                result.AppendLine("no results");
            }

            this.Output.Append(result.ToString());
        }

        private static List<IPerformance> GetMatchingOrderedPerformances(IList<IPerformance> performances, string lowercasedSearchWord, DateTime searchedDate)
        {
            var matchingPerformances = performances
                .Where(p => p.Name.ToLower().Contains(lowercasedSearchWord)
                    && p.StartTime >= searchedDate)
                .OrderBy(p => p.StartTime)
                .ThenByDescending(p => p.BasePrice)
                .ThenBy(p => p.Name)
                .ToList();

            return matchingPerformances;
        }
    }
}
