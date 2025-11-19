using System;

public class Program
{
    static void Main(string[] args) 
    {
        var voice = new VoiceToTextProtocol(); //<-- Created an instance of a VoiceToTextProtocol class

        //TLDR Figure out with teach how to make the path for the model document itself be embeded in the project as to make it compatible with other computres / enviroments
        voice.VoiceToTextProtocolCreator("C:\\Users\\gd81mateo\\Desktop\\VFS_LOCAL\\Term 1\\Programing\\Deliverable1TestOnLowerNet\\VoskLite");//<-- Initialized the model with the path to it
        //Meanwhile every time you get to a new enviroment just change the path to the model folder accordingly by copying its path from the project itslef in the ASK THE TEACH folder

        Console.Clear();
        Console.WriteLine("Hello player, what is your name?");
        string playerName = voice.ReadPlayersInput(); //<-- Used the ReadPlayersInput method to get the player's name via voice input

        Console.WriteLine($"Welcome, {playerName}!");

        

    }

}
