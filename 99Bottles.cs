using System;

class Program
{
	static void Main()
	{
		_01:  int b = 0;
		_05:  string t = "";
		_10:  for(b = 99; b > 0; b--){
		_20:  goto _100;
		_30:  t = t + " OF BEER ON THE WALL";
		_40:  Console.Write(t + ", " + t);
		_50:  Console.Write("\nTAKE ON DOWN AND PASS IT AROUND, ");
		_60:  if(b - 1 <= 0) { Console.Write("NO MORE BOTTLES OF BEER ON THE WALL"); } goto _80;
		_70:  goto _200;
		_75:  Console.Write(" OF BEER ON THE WALL");
		_80:  Console.WriteLine();
		_85:  goto _230;
		_90:  Console.Write("GO TO THE STORE AND BUY SOME MORE, 99 BOTTLES OF BEER ON THE WALL");
		_95:  return;
		_100: t = b.ToString() + " BOTTLE"; if (b > 1) { t = t + "S"; }
		_110: goto _30;
		_200: Console.Write((b - 1).ToString() + " BOTTLE");
		_210: if (b - 1 > 1) { Console.Write("S"); }
		_220: goto _75;
		_230: ;}
	}
}