#include <iostream> //��ó�� ������
#include <climits>
using namespace std;
// C++���� �Լ��� ����ϰ��� �Ѵٸ� �ݵ�� �� �Լ��� ������ �̸� �����Ͽ����Ѵ�.
// ';' �������� ������ �Ѵ�

//����Ǵ� �Լ� main()�� ������ �־���Ѵ�.
int main() {
	
	//�ٹٲޱ���
	cout << "Hello, World" << endl;
	cout << "Hi" << endl;

	/*
	1. ���ڷ� ������ �� ����.
	2. c++ ���� ����ϰ� �ִ� Ű����� ��� x
	3. white space��� x
	*/

	int a = 7;
	int b = 5;

	//&a => �ּ� ��
	cout << "a = " << &a << ", b = " << b << endl;

	//������ : �Ҽ��ΰ� ���� ��
	//short, int, long, long long

	int i = INT_MAX;

	cout << i << endl;

	//char, bool
	char c = 'c';

	//bool : 0 Ȥ�� 1 -> 0�̿��� ���� 1

	
	//���� ���̸� ���ϴ� ���α׷�

	// �ٲ� �ʿ䰡 ���¼�, �ٲ��� �ȵǴ� �� -> const (�ڷ� �� ���� �����)
	const float PIE = 3.14159;

	//������ ����������ȯ
	//typeName(a) typeName(a)
	char ch = 'M';
	cout << static_cast<int>(ch) << " " << int(ch) << endl;

	//auto -> �ڵ����� ��������, ���� �߻����ɼ� ����
	auto n = 100; //-> int;

	/*
	�迭 : ���� ���������� ����
	*/
	short month[12] = { 1, 2, 3 };
	cout << month[0] << endl;

	//�迭�� �κ������� �ʱ�ȭ�ϸ�, ������ ���ҵ��� ��� 0���� �����Ѵ�.
	//ch �迭�� ����Ҷ� �� ���ڱ����� ����Ѵ�.
	char ch[6] = { 'h','e','l','l','o','\0' }; // hello
	char cs[6] = "hello"; // hello


	return 0;

}