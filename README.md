# IDMbWebScraper

This app uses IMDB's REST API to retrieve the plot of a tv show or movie, as well as the main cast. It also scrapes the web for movie theathers nearby and top rated movies.

## Examples

### Search

#### Movie Information
We run the program and see the first window pop up. 

Let's choose 'Spider-Man' as the title for the movie and add 2012 as the year.

We will then hit the Search button and watch the API return the plot and the list of actors.

If the movie has multiple parts, like Spider-Man 1, 2, 3, the API will return the first movie that came out chronologically if we exclude the year.

#### Movie Theaters
This will search for movie theaters in the location of your choice.
As an example, in the first text box, search New York, and in the second text box, type NY then hit enter or the Get Theaters button.
This will search nearby movie theaters to New York city.

#### Top Rated Movies
This will display IMDb's top 250 rated movies.

### What you'll need to run the code:

* Internet connection

* Visual Studios 2012 v 11.0

* IMDB API Key

### Download the latest versions:

https://visualstudio.microsoft.com/downloads/

http://www.omdbapi.com/apikey.aspx

CSS inspired by https://github.com/EngstromJimmy/Dotnetconf-CreateAGreatUX
