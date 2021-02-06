<p align="center"><img src="https://github.com/dev-john-reid/RainProbably/blob/master/ClientApp/src/assets/rp.png"  width="300" height="300" /></p>

# A simple web app for viewing the next 5 days of weather for Belfast, NI.

Being a little unfamiliar with .Net core and having not created an Angular app from scratch for the last couple of years, I started this project by simply creating an Angular/WebAPI solution in Visual Studio and building on what it gave me. This actually allowed to me to meet the brief without having to put a masive amount of work into getting the project set up, enabling me to focus on getting the interactions with the 3rd party API correct.

## Comments

The brief stated that "The application will communicate to the following REST API: https://www.metaweather.com/api/ and retrieve the next 5 days of weather for Belfast.". Having looked into the API I found that in order to get the forecast for a location you need it's ID (specific to this API), which can be found using the API's search function. As we are simply wanting to display a 5 day weather forecast for 1 specific place (Belfast), I opted to find the ID manually and just hardcode the URL in the RestService. This is pretty dirty and not something I would usually do but it saves time and doesn't create too many problems unless we start to expand the scope of the app, at which point I can fix this up to be more flexible very easily. It would be fairly simple to allow a user to search for their own location using this API but that isn't requested.

Another note on API interactions is that, whilst you can request forecast data for a specific date and location, I found that making a single summary request for a location would give you details of 6 days of weather for the location, starting from today. I figured that using the data from this 1 request to populate the data needed for the page would be more efficient than making 5 separate ones. 

This then left me with a bit of a conundrum; Does "the next 5 days" include today? I decided to go with no, despite feeling that as a user I would expect today's data to be in a 5 day forecast, this is purely because in the brief the word "next" is always used when referring to the 5 days. If this were a real project I would almost certainly have an opportunity to confer and clarify on what the requirement here was.

I used IdentityServerSPA for authentication as it comes out of the box in VS and was adequate for my needs here, allowing me to lock the forecast requests behind an Authorize only controller. The project includes the migration required to setup the SQL tables for this but I have not included any DB files.

## Example Forecast
<p align="center"><img src="https://i.imgur.com/1zB4NrM.png" /></p>


    
