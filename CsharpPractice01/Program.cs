 internal class Program
    {
        static void Main(string[] args)
        {
			//키워드, 식별자 연습
			//string name = "권민기";
			//string id = "26031005";
			//string subject = "객체지향 C#";

			//Console.WriteLine($"이력서");
			//Console.WriteLine($"이름: {name}");
			//Console.WriteLine($"학번: {id}");
			//Console.WriteLine($"과목: {subject}");

			//연산연습
			//Console.WriteLine(10 + 2000);
			//Console.WriteLine(10 + "2000");
			//Console.WriteLine(Int32.Parse("10") + 2000);
			//Console.WriteLine("10" + "2000");


			// 연산 연습
			//Console.WriteLine((12345 % 10)/1);
			//Console.WriteLine((12345 % 100) / 10);
			//Console.WriteLine((12345 % 1000) / 100);
			//Console.WriteLine((12345 % 10000) / 1000);
			//Console.WriteLine((12345 % 100000) / 10000);


			// x % y = x - (x / y) * y
			//Console.WriteLine(4 % 3);
			//Console.WriteLine(4 % -3);      //  4 - ( 4/-3) * (-3)
			//Console.WriteLine(-4 % 3);     //  4 - (-4/3) * (3)
			//Console.WriteLine(-4 % -3);    // -4 - (-4/-3) *(-3)

			//Console.WriteLine(12345.0 / 1000.0);

			//Console.WriteLine(1 / 2);
			//Console.WriteLine(1.0 / 2.0);

			//Console.WriteLine(5.0 % 2.2);
			//Console.WriteLine(0.6 / 1.0);

			//문자형
			//Console.WriteLine("똚");

			// 문자열
			//Console.WriteLine("이력서");
			//Console.WriteLine("\t\t이름: 권민기");


			//인덱스는 0부터
			//Console.WriteLine("안녕하세요"[0]);
			//Console.WriteLine("안녕하세요"[1]);
			//Console.WriteLine("안녕하세요"[2]);
			//Console.WriteLine("안녕하세요"[4]);
			//Console.WriteLine("안녕하세요"[1004]);

			//Console.WriteLine("한" + "글");

			//Console.WriteLine('난' + '0XAC00');

			//boolean
			//Console.WriteLine(true);
			//Console.WriteLine(false);

			//변수
			//int idNumber = 1000000000;
			//long gameMoney = 1000000000000000;
			//double score = 98.5;
			//char character = 'a';
			//string message = "안녕하세요";

			//idNumber = 15;

			//gameMoney = 200;

			//Console.WriteLine(idNumber % gameMoney);

			//int a = 2147483640;
			//int b = 52273;
			//Console.WriteLine(a+b);


			//Console.WriteLine(int.MinValue);
			//Console.WriteLine(int.MaxValue);
			//Console.WriteLine(uint.MinValue);
			//Console.WriteLine(uint.MaxValue);
			//Console.WriteLine(long.MinValue);
			//Console.WriteLine(long.MaxValue);

			//Console.WriteLine(sizeof(byte));
			//Console.WriteLine(sizeof(char));
			//Console.WriteLine(sizeof(short));
			//Console.WriteLine(sizeof(int));
			//Console.WriteLine(sizeof(long));
			//Console.WriteLine(sizeof(float));
			//Console.WriteLine(sizeof(double));



			//0과 1이 모여있는 것이 비트
			//1바이트 = 8비트	2의(256) 8승 - 1=255 2의 10승 = 1024			
			// char = 2바이트

			//char value1 = 'a' = 'A' + 32; //여기 a에 숫자 들어간다고 숫자가 아니다에요 ㅇㅇ
			//char value2 = 'A';
			//Console.WriteLine(value1 + value2);
			//Console.WriteLine(value1 - value2);
			//Console.WriteLine(value1 * value2);
			//Console.WriteLine(value1 / value2);
			//Console.WriteLine(value1 % value2);

			//                 0 1 2 3 4 5 6 7 8 9 //띄어쓰기도 똑같이 계산한다.
			//string message1 = "안녕하세요. 전혀 반갑지 않아요 샤갈 ♡";
			//string message2 = "진짜 C샵 너무 싫다에요 에히히";

			//Console.WriteLine(message1[1]);
			//Console.WriteLine(message2.Length);

			//double val;  // System.Int32 val 
			// float val;   // System.Single val


			//int value3 = 12345;

			//value3 += 200; Console.WriteLine(value3);
			//value3 -= 200; Console.WriteLine(value3);
			//value3 *= 200; Console.WriteLine(value3);
			//value3 /= 200; Console.WriteLine(value3);
			//value3 %= 200; Console.WriteLine(value3);

			//string m1 = "Hello";
			//m1 += " World";

			//string resDir  ="resource/";

			//string textureFile = "m1.png";

			//string texPath = resDir + textureFile;

			//texture load;

			//Console.WriteLine(texPath);	


			//단항 연산자

			//int value = 100;
			//int result = 0;

			//result = value++; Console.WriteLine($"result: {result} value : {value}"); // value += 1;
			//result = ++value; Console.WriteLine($"result: {result} value : {value}"); // value += 1;

			//value ++;
			//result = value;
			//value = value + 1;	

			//result = value--; Console.WriteLine($"result: {result} value : {value}"); // value += 1;
			//result = --value; Console.WriteLine($"result: {result} value : {value}"); // value += 1;

			////value --;
			////result = value;
			////value = value - 1;	


			////GetType() : 객체의 타입을 반환	

			////정밀도  = 싱글

			//Console.WriteLine(10.GetType());	
			//Console.WriteLine(10.0F.GetType());	
			//Console.WriteLine('한'.GetType());
			//Console.WriteLine("message".GetType());
			
			//var value = "안녕하세요";
			//Console.WriteLine("value type: " + value.GetType());

			//var val11 = 0      ; Console.WriteLine($"val11 type: { val11.GetType() }");
			//var val12 = 0.0    ; Console.WriteLine($"val12 type: { val12.GetType() }");
			//var val13 = 0.0F   ; Console.WriteLine($"val13 type: { val13.GetType() }");
			//var val14 = '가'   ; Console.WriteLine($"val14 type: { val14.GetType() }");
			//var val15 = "문자열"; Console.WriteLine($"val15 type: { val15.GetType() }");
			//var val16 = val13  ; Console.WriteLine($"val16 type: { val16.GetType() }");


			//long val10 = 0L    ; Console.WriteLine($"val10 type: { val10.GetType() }");
			//int val11 = 0      ; Console.WriteLine($"val11 type: { val11.GetType() }");
			//double val12 = 0.0  ; Console.WriteLine($"val12 type: { val12.GetType() }");
			//float val13 = 0.0F  ; Console.WriteLine($"val13 type: { val13.GetType() }");
			//char val14 = '가'   ; Console.WriteLine($"val14 type: { val14.GetType() }");
			//string val15 = "문자열"; Console.WriteLine($"val15 type: { val15.GetType() }");
			//float val16 = val13  ; Console.WriteLine($"val16 type: { val16.GetType() }");











		}
	}

