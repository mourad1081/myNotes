using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace myNotes.Model
{
    class Notes
    {
        private List<Note> MesNotes { get; set; }
        private const string NOM_FICHIER_DEFAUT = "notes.sav";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathnotes">Path vers le fichier .mynotes contenant les notes à charger.</param>
        public Notes(string pathnotes = NOM_FICHIER_DEFAUT)
        {
            if (!File.Exists(pathnotes)) // Si le fichier passé en paramètre n'existe pas
                if(File.Exists(NOM_FICHIER_DEFAUT)) // On charge le fichier de notes par défaut s'il existe
                    this.MesNotes = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText(NOM_FICHIER_DEFAUT));
                else // Sinon on le créé
                    File.Create(NOM_FICHIER_DEFAUT);
            else // Il existe, on le charge
                this.MesNotes = JsonConvert.DeserializeObject<List<Note>>(File.ReadAllText(pathnotes));
        }

        public void AddNote(Note note)
        {
            MesNotes.Add(note);
        }

        public void DeleteNote(Note note)
        {
            MesNotes.Remove(note);
        }

    }
}
