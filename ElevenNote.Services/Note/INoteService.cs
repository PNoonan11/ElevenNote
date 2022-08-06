using ElevenNote.Models.Note;
using System.Threading.Tasks;
using System.Collections.Generic;
using ElevenNote.Services.Wrappers;
using ElevenNote.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace ElevenNote.Services.Note
{
    public interface INoteService
    {
        Task<bool> CreateNoteAsync(NoteCreate request);
        Task<IEnumerable<NoteListItem>> GetAllNotesAsync(PaginationFilter filter, HttpContext httpContext);
        Task<NoteDetail> GetNoteByIdAsync(int noteId);
        Task<NoteDetail> GetNoteByIsStarredAsync(bool star);
        Task<bool> UpdateNoteAsync(NoteUpdate request);
        Task<bool> DeleteNoteAsync(int noteId);

    }
}