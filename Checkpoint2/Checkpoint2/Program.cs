using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Checkpoint2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var roomList = CreateRooms();
            DisplayRooms(roomList);
        }

        public static void DisplayRooms(List<Room> roomList)
        {
            int counter = 0;
            int lightcounter = 0;
            int largestRoomSize = 0;
            string lightRooms = "Ljust är tänt i ";
            string largestRoom = "";
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var room in roomList)
            {
                //Console.WriteLine($"* Rumnamn {counter} : {room.RoomName}");
                counter++;
            }

            foreach (var room in roomList)
            {
                if (room.RoomSize > largestRoomSize)
                {
                    largestRoomSize = room.RoomSize;
                    largestRoom = room.RoomName;
                }
                if (room.RoomLights == "On" || room.RoomLights == "on")
                {
                    lightcounter++;
                    lightRooms = lightRooms + $"{room.RoomName}";
                }

            }
            if (lightcounter == 0)
            {
                Console.WriteLine("Det är släckt i alla rum");
            }
            else
                Console.WriteLine(lightRooms);

            Console.WriteLine($"Det största rummet är {largestRoom}, på {largestRoomSize}m2");
            Console.WriteLine($"Lägenheten består av {counter} rum");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

        }

        public static List<Room> CreateRooms()
        {
            do
            {
                var roomList = new List<Room>();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ange rum i lägenehten: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string[] roomString = Console.ReadLine().Split(" | ");
                Console.WriteLine();
                //foreach (string item in roomString)
                //{
                //    if (!ValidInput(item))
                //    {
                //        Console.ForegroundColor = ConsoleColor.Red;
                //        Console.WriteLine("Ogiltig indata");
                //    }

                //}
                foreach (string input in roomString)
                {
                    string name = input.Split(' ')[0];
                    string roomSizeString = input.Split(' ')[1];
                    string roomSizeString2 = roomSizeString.Split("m2")[0];
                    int roomSize = int.Parse(roomSizeString2);
                    string lights = input.Split(' ')[2];

                    var room = new Room
                    {
                        RoomName = name,
                        RoomSize = roomSize,
                        RoomLights = lights
                    };
                    roomList.Add(room);
                }
                return roomList;
            } while (true);

        }
        //private static bool ValidInput(string input)
        //{
        //    return Regex.IsMatch(input, @"^[a-zåäö]+, ,\d+,m2, ,(on|off)$", RegexOptions.IgnoreCase);
        //}
    }
}
