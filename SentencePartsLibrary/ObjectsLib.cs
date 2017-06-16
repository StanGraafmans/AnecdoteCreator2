﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentencePartsLibrary
{
    public class ObjectsLib
    {
        private static Random r = new Random();

        public static string[] GetList()
        {
            return new string[]
            {
                "pie",
                "wood",
                "rock",
                "paint",
                "money",
                "humour",
                "wealth",
                "an opinion",
                "water",
                "gold",
                "glass",
                "a laptop",
                "a house",
                "a train",
                "Vitas",
                "an island",
                "you-know-who",
                "you-know-what",
                "something",
                "a Nokia",
                "a can",
                "a flashlight",
                "a bakery",
                "bleach",
                "suicide",
                "depression",
                "anime",
                "a piano",
                "easter",
                "christmas",
                "that weird thing",
                "Thomas the dank engine",
                "Minecraft",
                "League of Legends",
                "Crystal Clear",
                "Monster Energy",
                "porn",
                "a knife",
                "a parade",
                "sharks",
                "a pig",
                "a mirror",
                "the end",
                "the world",
                "an anime convention",
                "time",
                "sound",
                "that alley",
                "wine",
                "piano lessons",
                "death",
                "murder",
                "school",
                "shit",
                "people",
                "a party",
                "a loan",
                "tabacco",
                "balloons",
                "a land",
                "an attack",
                "a terrorist",
                "terrorists",
                "a circus",
                "power",
                "Overwatch",
                "balls",
                "numbers",
                "a lottery",
                "internet",
                "a git commit",
                "a thing",
                "a tree",
                "a plane",
                "manga",
                "a well cooked pancake",
                "a cat",
                "a weird creature",
                "a corner",
                "a dog",
                "a keycap",
                "a sticker",
                "creatures",
                "flying objects",
                "unicorns",
                "lampposts",
                "buildings",
                "lan-parties",
                "the fucking lamb sauce",
                "oranges",
                "organs",
                "beer",
                "butter",
                "a mouse",
                "a jacket",
                "a banana",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you",
                "you"
            };
        }

        public static string GetRandom()
        {
            return GetList()[r.Next(GetList().Length)];
        }
    }
}
