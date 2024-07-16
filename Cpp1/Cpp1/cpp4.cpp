#include <iostream>
#include <cstring>

using namespace std;
//
//int main() {
//	//반복문이란 ?
//	//조건식이 true일때만 반복문 돈다.
//	for (int i = 0; i < 5; i++) {
//		cout << i << "번째 입니다." << endl;
//	}
//
//	/*
//	1. 반복문에 사용할 카운터의 값을 초기화
//	2. 반복문을 진행할 것인지 '조건 검사'
//	3. 반복문 몸체를 수행합니다.
//	4. 카운터의 값을 변화합니다.
//	*/
//	int a = 10, b = 10;
//	//10
//	cout << "a++ : " << a++ << endl;
//	//11
//	cout << "++b : " << a++ << endl;
//
//	//while문 , do while문
//	//string 마지막에 null존재
//	string str = "panda";
//	int i = 0;
//	
//	//관계 표현식 없이 사용할 수 있다.
//	//카운터 선언이 선행되어야한다.
//	while (str[i] != '\0') {
//		cout << str[i] << endl;
//		i++;
//	}
//	
//	//do while 일단 반복을 실행하고 나서 조건을 판단한다.
//
//	//배열 기반 반복문
//	int arr[5] = { 1,3,5,7,9 };
//	
//	for (int i : arr) {
//		cout << i << " ";
//	}
//	cout << endl;
//
//	//중첩 루프
//	int temp[4][5];
//	int cnt = 0;
//	for (int i = 0; i < 4; i++) {
//		for (int j = 0; j < 5; j++) {
//			temp[i][j] = ++cnt;
//			cout << temp[i][j] << " ";
//		}
//		cout << endl;
//	}
//	
//	cout << "문장을 입력하세요\n";
//	
//	const int Size2 = 20;
//	char line[Size2];
//
//	cin.get(line, Size2);
//	cout << "입력하신 문장은 \n";
//	int space = 0;
//	for (int i = 0; line[i] != '\0'; i++) {
//		cout << line[i];
//		if (line[i] == ' ')
//			continue;
//
//		space++;
//	}
//	cout << "입니다\n";
//	cout << "입력하신 문장에서 공백을 제외한 문자는" << space << "개입니다\n";
//
//	
//	return 0;
//}