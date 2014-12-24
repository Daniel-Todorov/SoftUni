'use strict';

app.controller('VideosController', ['$scope', 'VideosDataWorker',
    function ($scope, VideosDataWorker) {

        var video = {
                title: 'Course introduction',
                pictureUrl: 'http://softuni.bg/picture.png',
                length: '3:32',
                category: 'IT',
                subscribers: 3,
                date: new Date(2014, 12, 15),
                haveSubtitles: false,
                comments: [
                    {
                        username: 'Pesho Peshev',
                        content: 'Congratulations Nakov',
                        date: new Date(2014, 12, 15, 12, 30, 0),
                        likes: 3,
                        websiteUrl: 'http://pesho.com/'
                    }
                ]
            },
            video2 = {
                title: 'Antroduction',
                pictureUrl: 'http://softuni.bg/picture.png',
                length: '3:35',
                category: 'DB',
                subscribers: 2,
                date: new Date(2013, 12, 15),
                haveSubtitles: false,
                comments: [
                    {
                        username: 'Pesho Peshev',
                        content: 'Congratulations Nakov',
                        date: new Date(2014, 12, 15, 12, 30, 0),
                        likes: 3,
                        websiteUrl: 'http://pesho.com/'
                    }
                ]
            },
            sortingFilters = [
                'title',
                'length',
                'date',
                'subscribers'
            ],
            videos;

        VideosDataWorker.addVideo(video);
        VideosDataWorker.addVideo(video2);
        videos = VideosDataWorker.getVideos();

        $scope.sortingFilters = sortingFilters;
        $scope.videos = videos;
    }]);