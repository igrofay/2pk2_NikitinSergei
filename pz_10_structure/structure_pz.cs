using System;

namespace Programm{
	class Main {
  		static void Main() {
			TRAIN[] RASP = new TRAIN[8];
			for(int i = 0; i < RASP.Length ; i++){
				Console.WriteLine("Ведите данные о поезде: ");
				Console.WriteLine("Номер поезда: ");
				int num = int.Parce(Console.ReadLine());
				Console.WriteLine("Название пункта назначения поезда: ");
				string name = Console.ReadLine();
				Console.WriteLine("Время отправления поезда( формат - hh:mm ): ");
				string time = Console.ReadLine();
				RASP[i] = new TRAIN(num,name,time);
			}
			sortInd(ref RASP);
			Console.WriteLine("Какой поезд вы хотите найти?\nНомер поезда: ");
			int num = int.Parce(Console.ReadLine());
			for(int i = 0; i < RASP.Length ; i++){
				if(RASP[i].NUMR == num){
					Console.WriteLine($"Поезд найден: {RASP[i].ToString()}");
				}else if (i == RASP.Length-1){
					Console.WriteLine("Незарегистрированный поезд!!!");
				}
			}
  		}
		static void sortInd(ref TRAIN[] RASP){
			for(int i = 0; i < RASP.Length ; i++){
				for(int y = i+1; y < RASP.Length ; y++){
					if (RASP[i].NUMR > RASP[j].NUMR){
						(RASP[i], RASP[y]) = (RASP[y], RASP[I]);
					}
				}
			}
		}
	}
	public struct TRAIN{
		string NAZN{ get; }
		int NUMR{ get; }
		string TIME{ get; }
		public TRAIN(int num, string name, string time){
			NAZN = name;
			NUMR = num;
			TIME = time;
		}
		public override string ToString() => $"Номер - {NUMR}\nПункт назначения - {NAZN}\nВремя - {TIME}";
	}
}
