To get 'The World' ASPNETCore to run you need to create the 'TheWorld' database locally.  This is not Azure hosted and is using EF Core.  

Connection string assumes that the end user is using a default instance of SQL Server on their machine.  
Else they will need to alter the connection under 'config.json' ConnectionStrings:WorldContextConnection as needed.

The Migrations are already in source control so you merely need to get to a command line once all the dependencies exist and type in:
'(Directory of source Control for 'TheWorld')dotnet ef Database update

Once the database shell exists the Dot Net core will populate as needed.  In EF 6.1.3 you can just use an initializer pattern in your context operation,
but I am not as privy to EF Core yet so I do it the way I learned online on a tutorial thus far.  Also you need to supply a Bing Maps API Key under config.json as well.  
Following best practices I won't share my key as I actually have another app that uses my key.