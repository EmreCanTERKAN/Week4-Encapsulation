using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Encapsulation
{


	public class Car
	{

		public Car(string marka, string model, string renk, int doornumber)
        {
			Marka = marka;
			Model = model;
			Renk = renk;
			DoorNumber = doornumber;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int _doorNumber;

		public int DoorNumber
		{
			get { return _doorNumber; }
			set
			{ 
				if ((value != 2 && value != 4))
				{
                    Console.WriteLine("Yanlış kapı değeri girdin....");
					_doorNumber = -1;
                }
				else
				{
                    _doorNumber = value;

                }
                
			}
		}

		public void CarInfo()
		{
            Console.WriteLine($"_____________________________\n Arabanın Modeli:{Marka}\n Markası {Model}\n Rengi : {Renk}\n Kapı Sayısı : {DoorNumber}");
        }

	}
















}