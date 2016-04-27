namespace myNotes.Model
{
    enum Priorite
    {
        BAS, NORMAL, ELEVE
    }
    class Note
    {
        private string titre { get; set; }
        private string contenu { get; set; }
        private Priorite priorite { get; set; }
        private Categorie categorie { get; set; }

        public Note(string titre = "", string contenu = "", Priorite priorite = Priorite.NORMAL, Categorie cat = null)
        {
            this.categorie = cat;
            this.titre = titre;
            this.priorite = priorite;
            this.contenu = contenu;
        }
    }
}