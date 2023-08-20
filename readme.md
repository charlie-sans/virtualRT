# virtualRT

welcome to the official virtualRT repository!

## what is virtualRT?

virtualRT is a file format designed to store data required by OpenStudioCorp's OpenNoteBlockStudioVR game 

## how do i use virtualRT?

just import VirtualRT and VirtualRT.NoteData into your project
```csharp
using VirtualRT;
using VirtualRT.NoteData;
```

then call 
```csharp
NoteDataList noteDataList = new NoteDataList();//create a new NoteDataList
noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));//add a new NoteData to the list
noteDataList.AddNoteData(new NoteData(60, "red", 100, 1.0, 2.0, 3.0, 0.5, 0.8));// you can call this as many times as you want, just do it before serializing the file.
NoteDataSerializer serializer = new NoteDataSerializer();//create a new NoteDataSerializer
serializer.Serialize(noteDataList.GetNoteDataList(), "noteData.json");//serialize the NoteDataList to a file
```

printing the file will result in this:
```
NotePitch: 60
NoteColor: red
Velocity: 100
XCoord: 1
YCoord: 2
ZCoord: 3
Opacity: 0.5
Brightness: 0.8

NotePitch: 60
NoteColor: red
Velocity: 100
XCoord: 1
YCoord: 2
ZCoord: 3
Opacity: 0.5
Brightness: 0.8
```
