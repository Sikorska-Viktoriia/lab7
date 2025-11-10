using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace lab1._2
{
    // ======================================
    // БЛОК ВИЗНАЧЕННЯ МОДЕЛЕЙ
    // ======================================

    // Інтерфейс IVehicle (Абстракція)
    public interface IVehicle
    {
        string Model { get; set; }
        string Manufacturer { get; set; }
        int Year { get; set; }
        double Price { get; set; }
        string GetDetails();
    }

    // Базовий клас Car (Успадкування + Інкапсуляція)
    public class Car : IVehicle
    {
        private string _model;
        private string _manufacturer;

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Manufacturer
        {
            get => _manufacturer;
            set => _manufacturer = value;
        }

        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string model, string manufacturer, int year, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            Price = price;
        }

        public virtual string GetDetails()
        {
            return $"Виробник: {Manufacturer}\n" +
                   $"Модель: {Model}\n" +
                   $"Рік: {Year}\n" +
                   $"Ціна: {Price:C}";
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year})";
        }
    }

    // Клас-нащадок ElectricCar
    public class ElectricCar : Car
    {
        public int BatteryRangeKm { get; set; }

        public ElectricCar(string model, string manufacturer, int year, double price, int range)
            : base(model, manufacturer, year, price)
        {
            BatteryRangeKm = range;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $"\nТип: Електромобіль\nЗапас ходу: {BatteryRangeKm} км";
        }

        public override string ToString()
        {
            return $"[EV] {base.ToString()}";
        }
    }

    // Клас-нащадок GasCar
    public class GasCar : Car
    {
        public double EngineVolumeL { get; set; }

        public GasCar(string model, string manufacturer, int year, double price, double volume)
            : base(model, manufacturer, year, price)
        {
            EngineVolumeL = volume;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $"\nТип: Бензиновий\nОб'єм двигуна: {EngineVolumeL:F1} л";
        }

        public override string ToString()
        {
            return $"[Gas] {base.ToString()}";
        }
    }

    // ======================================
    // Основна форма 
    // ======================================
    public partial class Form1 : Form
    {

        private List<IVehicle> carInventory = new List<IVehicle>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Демонстрація ООП: Автосалон";


            if (Controls.Find("labelDetails", true).Length > 0)
            {
        
                Controls.Find("labelDetails", true)[0].Text = "Натисніть 'Завантажити дані' для початку.";
            }
            else
            {
    
                labelDetails.Text = "Натисніть 'Завантажити дані' для початку.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

   
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            carInventory.Clear();
            listBoxVehicles.Items.Clear();

     
            carInventory.Add(new ElectricCar("Model S", "Tesla", 2024, 85000.0, 650));
            carInventory.Add(new GasCar("Camry", "Toyota", 2023, 32000.0, 2.5));
            carInventory.Add(new ElectricCar("Leaf", "Nissan", 2022, 28000.0, 250));
            carInventory.Add(new GasCar("Golf", "VW", 2024, 28000.0, 1.4));


            foreach (var vehicle in carInventory)
            {
                listBoxVehicles.Items.Add(vehicle);
            }

           
            labelDetails.Text = "Дані завантажено. Виберіть автомобіль для деталей.";
            buttonLoadData.Enabled = false;
        }


        
        private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVehicles.SelectedItem == null) return;


            IVehicle selectedVehicle = listBoxVehicles.SelectedItem as IVehicle;

            if (selectedVehicle != null)
            {
       
                labelDetails.Text = selectedVehicle.GetDetails();
            }
        }
    }
}