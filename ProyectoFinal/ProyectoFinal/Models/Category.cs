using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProyectoFinal.Annotations;

namespace ProyectoFinal.Models
{
    public class Category
    {
        private int categoryID;

        public int id
        {
            get { return categoryID; }
            set
            {
                categoryID = value; 
                OnPropertyChanged();
            }
        }

        private string categoryName;

        public string name
        {
            get { return categoryName; }
            set
            {
                categoryName = value; 
                OnPropertyChanged();

            }
        }

        private string imageCategory;
        
        public string image
        {
            get { return imageCategory; }
            set
            {
                imageCategory = App.GlobalMedialUrl+value;
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        
        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}