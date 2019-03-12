using System;
using SQLite;

namespace PatchNotes
{
    public interface ISQLiteService
    {
        SQLiteConnection GetConnection(string PatchNotesDatabase);
        long GetSize(string PatchNotesDatabase);
    }
}



