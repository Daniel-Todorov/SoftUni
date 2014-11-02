
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


/**
 * Problem 8.	Extract Emails
 * 
 * Write a program to extract all email addresses from given text. The text 
 * comes at the first input line. Print the emails in the output, 
 * each at a separate line. Emails are considered to be in format <user>@<host>, where:
 * <user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. 
 * <host> is a sequence of at least two words, separated by dots '.'. 
 * Each word is sequence of letters and can have hyphens '-' between the letters. 
 * 
 */

public class ExtractEmails {
    
    	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
                System.out.print("Please, type a text with emails and press Enter: ");
		String text = in.nextLine().toLowerCase();
		Pattern emailPattern = Pattern.compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");
		Matcher matcher = emailPattern.matcher(text);
                
		while (matcher.find()) {
                    System.out.println(matcher.group());
		}
	}
        
}
