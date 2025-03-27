# DroidHack
The start and exploration of a game to help teach software development by programming little virtual droids.  

Or so I thought.  This was the original thought when I started this project.  oh, we need a 
way to teach scouts at the national jamboree some simple programming skills, but
in an environment that they could easily see things happen, and make them do 
tasks that were simple to do, within about a 30-45 minute timeframe.

It quickly devolved when I remembered that  game RoboCode and RobotWar, which allow you to 
develop a robot, write the code, and turn it lose to fight a bunch of other
robots in a small arena.  Well, why can't we do that, but better?  lets turn it
up to Eleven....

So here's the project scope:

*DroidHack is an educational game that emphasizes learning a programming language
through the development of a virtual droid that can then interact with it's 
environment.  Modes include world exploration, tutorial, and competition, either 
individual or player versus player.*

now lets define what you're seeing now
## DroidEditor
we'll need to edit a droid.  this includes writing the program, and in more advanced 
realms, adding new devices and other items to your droid.

## Repository.SqlServer
Where the data is stored.  I'll start with SQL Server, but that may not 
cut it long term.  The Repository.Interface is how the rest of the system sees
the data, so this may change names

## Repository.Interface
How the rest of the system sees the database.  Repository.Interface will 
hold the interfaces and external facing data models, which may not be what is
actually stored in the repository.  

## WorldServer
a world is the embodiment of the environment a droid can interact with.  it could be
a simple arena, a complex world, or a series of challenges that a droid must overcome.

## UserManagement
We'll have users.  if you're running completely local, it's probably not an issue,
but once you start releasing your world to others, or we want to rank people, 
we'll need some way of managing this.  User Management will handle the task of 
knowing who is related to what.

## WorldRegistry
You've got a world, and You've got a world, and You've got a world, so how do you let people
know that they are out there?  well the registry is where you'll connect and 
tell the world (heh)

## WorldEditor
Edit your world, tailor it as you want, and then turn it loose.