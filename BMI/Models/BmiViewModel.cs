using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.Models
{
    
    public partial class BmiViewModel:ObservableObject
    {
        public BmiViewModel()
        {
            this.Height = 175;
            this.Weight = 70;
        }
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TextWeight))]
        [NotifyPropertyChangedFor(nameof(BMIndex))]
        double weight;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TextHeight))]
        [NotifyPropertyChangedFor(nameof(BMIndex))]
        double height;

        public string TextHeight { get { return $"{Math.Round(Height,0)} cm"; } }
        public string TextWeight { get { return $"{Math.Round(Weight,0)} kg"; } }

        public double BMIndex { 
            get {
                double result = Math.Round(Weight / Math.Pow(Height / 100d, 2),1);
                if(result < 18.5d)
                {
                    Estimate = "Underweight";
                }
                else if(result < 24.9)
                {
                    Estimate = "Healthy weight";
                }else if(result < 29.9)
                {
                    Estimate = "Overweight";
                }
                else
                {
                    Estimate = "Obesity";
                }
                return result; 
            } 
        }

        [ObservableProperty]
        string estimate;

        [RelayCommand]
        void PlusHeight()
        {
            if(Height<230)
                Height++;
        }
        [RelayCommand]
        void MinusHeight()
        {
            if(Height>50)
                Height--;
        }
        [RelayCommand]
        void MinusWeight()
        {
            if(Weight>30)
                Weight--;
        }
        [RelayCommand]
        void PlusWeight()
        {
            if(Weight<200)
                Weight++;
        }
    }
}
