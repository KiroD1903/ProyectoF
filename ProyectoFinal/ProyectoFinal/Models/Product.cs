using System.ComponentModel;
using System.Runtime.CompilerServices;
using ProyectoFinal.Annotations;

namespace ProyectoFinal.Models
{
    public class Product: INotifyPropertyChanged
    {
        private int productID;

        public int id
        {
            get { return productID; }
            set
            {
                productID = value; 
                OnPropertyChanged();
            }
        }

        private string productName;

        public string name
        {
            get { return productName; }
            set
            {
                productName = value; 
                OnPropertyChanged();

            }
        }

        private float productPrice;
        
        public float price
        {
            get { return productPrice; }
            set
            {
                productPrice = value; 
                OnPropertyChanged();

            }
        }
        
        private string productImage;

        public string image
        {
            get { return productImage; }
            set
            {
                productImage = App.GlobalMedialUrl + value; 
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