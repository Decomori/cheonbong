//자연수 N이 주어졌을 때, 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.
using System;
using System.Text;

public class B2741{
	public static void Main(String[] args){
		int n = int.Parse(Console.ReadLine().Trim());
		StringBuilder sb = new StringBuilder();
			for (int i = 1; i <= n; i++)
            { 
                sb.AppendLine(i.ToString()); 
            } 
        Console.Write(sb.ToString());
	}
}