/*두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
첫째 줄에 테스트 케이스의 개수 T가 주어진다.

각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)*/

using System;

public class B10950{
	public static void main(String[] args){
		
		int a, b, n;
		
		n = int.Parse(Console.ReadLine());
		
		for(int i=0; i<n; i++){
            a = Console.Read() - 48;
            Console.Read();
            b = Console.Read() - 48;
            Console.WriteLine(a + b);
            Console.ReadLine();
		}
	}
}