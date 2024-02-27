using System;
using System.Security.Cryptography;
using System.Threading;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        //maak hier class variables aan:

        // type=string, naam: name,
        string name = "HellDiver7854";
        // type=string, naam: lastStreamName
        string lastStreamName = "hardest hell dive yet";
        // type=Game, naam: streamGame
        Game steamGame = (new Game("Helldivers 2"));
        // type=int, naam: followers
        int followers = 1000;
        // type=bool, naam: automod
        bool automod = true;
        
    }
}