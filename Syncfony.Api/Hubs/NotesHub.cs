using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Syncfony.Api.Models;

namespace Syncfony.Api.Hubs
{
    public class NotesHub : Hub
    {
        public async Task HitNote(MidiNote note)
        {
            Console.WriteLine($"{note.Note} at {note.Velocity}");

            await Clients.All.SendAsync("NoteHit", note);
        }

        public async Task ReleaseNote(MidiNote note)
        {
            await Clients.All.SendAsync("NoteReleased", note);
        }
    }
}