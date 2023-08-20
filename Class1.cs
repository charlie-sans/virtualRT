using System;
using System.IO;
using System.Text.Json;
namespace virtualRT
{
    public class NoteData
    {
        public int NotePitch { get; set; }
        public string NoteColor { get; set; }
        public int Velocity { get; set; }
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public double ZCoord { get; set; }
        public double Opacity { get; set; }
        public double Brightness { get; set; }

        public NoteData(int notePitch, string noteColor, int velocity, double xCoord, double yCoord, double zCoord, double opacity, double brightness)
        {
            NotePitch = notePitch;
            NoteColor = noteColor;
            Velocity = velocity;
            XCoord = xCoord;
            YCoord = yCoord;
            ZCoord = zCoord;
            Opacity = opacity;
            Brightness = brightness;
        }
        public class NoteDataSerializer
    {
        public void Serialize(List<NoteData> noteDataList, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(noteDataList);
            File.WriteAllText(filePath, jsonString);
        }

        public List<NoteData> Deserialize(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<NoteData>>(jsonString);
        }
    }
    public class NoteDataList
    {
        private List<NoteData> _noteDataList;

        public NoteDataList()
        {
            _noteDataList = new List<NoteData>();
        }

        public void AddNoteData(NoteData noteData)
        {
            _noteDataList.Add(noteData);
        }

        public void AddNoteDataList(List<NoteData> noteDataList)
        {
            _noteDataList.AddRange(noteDataList);
        }

        public List<NoteData> GetNoteDataList()
        {
            return _noteDataList;
        }
    }
    }
}