using System;
using System.Collections.Generic;


//Void Function for printingmovies
void PrintMovie(string _title, string _director, string _playTime, int _releaseYear, double _rating)
{

    Console.WriteLine($"The title of the movie is {_title} and the director is {_director}. " +
        $"The movie has a playtime of {_playTime}, it was released in {_releaseYear} and it has a user rating of {_rating}");

}
 
// testing PrintMovie Function
PrintMovie("Titanic", "Bill Gates", "2h 30min", 1991, 9.5);
Console.WriteLine("\n"); // "\n" means go to a new line, example at end
PrintMovie("Scary Movie", "Marilyn Monroe", "1h 30min", 2006, 6.69);
Console.WriteLine("\n"); 

// String function instead of void function, main difference here is, the 'return' keyword;
string PrintMovieString(string _title, string _director, string _playTime, int _releaseYear, double _rating)
{
    return $"The title of the movie is {_title} and the director is {_director}. " +
        $"The movie has a playtime of {_playTime}, it was released in {_releaseYear} and it has a user rating of {_rating}";
}

//testing PrintMovieString
Console.WriteLine("This is PrintMovieString - " + PrintMovieString("Titanic", "Bill Gates", "2h 30min", 1991, 9.5));
Console.WriteLine("\n");
Console.WriteLine("This is PrintMovieString - " + PrintMovieString("Scary Movie", "Marilyn Monroe", "1h 30min", 2006, 6.69));
Console.WriteLine("\n");

// "\n" example use
Console.WriteLine("Every \n Word \n Is \n On \n A \n New \n Line");





