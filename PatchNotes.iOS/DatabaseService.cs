using System;


//DatabaseService.cs
//iOS Implementation of the IDBInterface CreateConnection method in the iOS Project
[assembly: Dependency(typeof(DatabaseService))]
namespace PatchNotes.iOS
{
    public class DatabaseService : IDBInterface
    {
        public DatabaseService()
        {
        }

        public SQLite.Net.SQLiteConnection CreateConnection()
        {
            var sqliteFilename = "PatchNotesDatabase.db";

            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            string path = Path.Combine(libFolder, sqliteFilename);

            // This is where we copy in the pre-created database
            if (!File.Exists(path))
            {
                var existingDb = NSBundle.MainBundle.PathForResource("PatchNotesDatabase", "db");
                File.Copy(existingDb, path);
            }

            var iOSPlatform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLite.Net.SQLiteConnection(iOSPlatform, path);

            // Return the database connection 
            return connection;
        }
    }
}