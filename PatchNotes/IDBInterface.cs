using System;
using SQLite;

namespace PatchNotes
{
    public interface IDBInterface
    {
        SQLiteConnection GetConnection(string PatchNotesDatabase);
        long GetSize(string PatchNotesDatabase);
    }
}



