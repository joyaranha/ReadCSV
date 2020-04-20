# Puzzle 1 - Count rows of a csv file
1. Create a commandline project named "ReadCSV" in visual studio using .Net Core
2. Copy the code in ReadCSV.txt to Program.cs 
3. change the hardcoded location of csv-sample.csv in Program.cs
4. build the project and execute it

# Puzzle 2 - Build a Docker Image

Created a (linux) docker image with Web API which returns my name and email address

Sample docker image can be found at [joyaranha/myname](https://hub.docker.com/repository/docker/joyaranha/myname)

```
docker pull joyaranha/myname:latest
docker run -it --rm -p 32776:80 --name myname joyaranha/myname:latest
```

Browse http://localhost:32776/WhoAmI and see what it returns.

```json
{
    "name":"Joy Aranha",
    "email":"joyaranha@yahoo.com"
}
```
