namespace YetAnotherNoteSaver.Models
{
    public class ModalModel : NoteModel
    {
        public string Display { get; set; } = "none;";
        public string Class { get; set; } = "";
        public bool Edit { get; set; } = false;
        public bool Backdrop { get; set; } = false;


        public void Open()
        {
            this.Display = "block;";
            this.Class = "show";
            this.Backdrop = true;
        }

        public void Close()
        {
            this.Display = "none";
            this.Class = "";
            this.Backdrop = false;
        }
    }
}
