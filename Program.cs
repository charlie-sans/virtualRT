using System.IO;
using System.Text.Json;
using virtualRT;
using static virtualRT.NoteData;

namespace virtualwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteDataList noteDataList = new NoteDataList();
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));
            noteDataList.AddNoteData(new NoteData(61, "blue", 90, 2.0, 3.0, 4.0, 0.6, 0.9));
            noteDataList.AddNoteData(new NoteData(62, "green", 80, 3.0, 4.0, 5.0, 0.7, 0.6));
            NoteDataSerializer serializer = new NoteDataSerializer();
            serializer.Serialize(noteDataList.GetNoteDataList(), "noteData.json");
            printthing();
        }
        static void printthing()
        {
            NoteDataSerializer serializer = new NoteDataSerializer();
            List<NoteData> noteDataList = serializer.Deserialize("noteData.json");
            foreach (NoteData noteData in noteDataList)
            {
                Console.WriteLine($"NotePitch: {noteData.NotePitch}");
                Console.WriteLine($"NoteColor: {noteData.NoteColor}");
                Console.WriteLine($"Velocity: {noteData.Velocity}");
                Console.WriteLine($"XCoord: {noteData.XCoord}");
                Console.WriteLine($"YCoord: {noteData.YCoord}");
                Console.WriteLine($"ZCoord: {noteData.ZCoord}");
                Console.WriteLine($"Opacity: {noteData.Opacity}");
                Console.WriteLine($"Brightness: {noteData.Brightness}");
                Console.WriteLine();
            }
        }
    }
}