using ElevenNote.Models.Note;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ElevenNote.Services.Note
{
    public interface INoteService
    {
        Task<bool> CreateNoteAsync(NoteCreate request);
        Task<IEnumerable<NoteListItem>> GetAllNotesAsync();
        Task<NoteDetail> GetNoteByIdAsync(int noteId);
        Task<NoteDetail> GetNoteByIsStarredAsync(bool star);
        Task<bool> UpdateNoteAsync(NoteUpdate request);
        Task<bool> DeleteNoteAsync(int noteId);
    }
}