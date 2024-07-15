#include <iostream> //전처리 지시자
#include <climits>
using namespace std;
// C++에서 함수를 사용하고자 한다면 반드시 그 함수의 원형을 미리 정의하여야한다.
// ';' 종결자의 역할을 한다

//실행되는 함수 main()을 가지고 있어야한다.
int main() {
	
	//줄바꿈까지
	cout << "Hello, World" << endl;
	cout << "Hi" << endl;

	/*
	1. 숫자로 시작할 수 없다.
	2. c++ 에서 사용하고 있는 키워드는 사용 x
	3. white space사용 x
	*/

	int a = 7;
	int b = 5;

	//&a => 주소 값
	cout << "a = " << &a << ", b = " << b << endl;

	//정수형 : 소수부가 없는 수
	//short, int, long, long long

	int i = INT_MAX;

	cout << i << endl;

	//char, bool
	char c = 'c';

	//bool : 0 혹은 1 -> 0이외의 값은 1

	
	//원이 넓이를 구하는 프로그럼

	// 바뀔 필요가 없는수, 바뀌어서는 안되는 수 -> const (자료 형 까지 써야함)
	const float PIE = 3.14159;

	//강제적 데이터형변환
	//typeName(a) typeName(a)
	char ch = 'M';
	cout << static_cast<int>(ch) << " " << int(ch) << endl;

	//auto -> 자동으로 데이터형, 오류 발생가능성 많다
	auto n = 100; //-> int;

	/*
	배열 : 같은 데이터형의 집합
	*/
	short month[12] = { 1, 2, 3 };
	cout << month[0] << endl;

	//배열을 부분적으로 초기화하면, 나머지 원소들은 모두 0으로 설정한다.
	//ch 배열을 출력할때 널 문자까지만 출력한다.
	char ch[6] = { 'h','e','l','l','o','\0' }; // hello
	char cs[6] = "hello"; // hello


	return 0;

}