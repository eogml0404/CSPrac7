#include <iostream>
#include <cstring>

using namespace std;
//
//int main() {
//	//�ݺ����̶� ?
//	//���ǽ��� true�϶��� �ݺ��� ����.
//	for (int i = 0; i < 5; i++) {
//		cout << i << "��° �Դϴ�." << endl;
//	}
//
//	/*
//	1. �ݺ����� ����� ī������ ���� �ʱ�ȭ
//	2. �ݺ����� ������ ������ '���� �˻�'
//	3. �ݺ��� ��ü�� �����մϴ�.
//	4. ī������ ���� ��ȭ�մϴ�.
//	*/
//	int a = 10, b = 10;
//	//10
//	cout << "a++ : " << a++ << endl;
//	//11
//	cout << "++b : " << a++ << endl;
//
//	//while�� , do while��
//	//string �������� null����
//	string str = "panda";
//	int i = 0;
//	
//	//���� ǥ���� ���� ����� �� �ִ�.
//	//ī���� ������ ����Ǿ���Ѵ�.
//	while (str[i] != '\0') {
//		cout << str[i] << endl;
//		i++;
//	}
//	
//	//do while �ϴ� �ݺ��� �����ϰ� ���� ������ �Ǵ��Ѵ�.
//
//	//�迭 ��� �ݺ���
//	int arr[5] = { 1,3,5,7,9 };
//	
//	for (int i : arr) {
//		cout << i << " ";
//	}
//	cout << endl;
//
//	//��ø ����
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
//	cout << "������ �Է��ϼ���\n";
//	
//	const int Size2 = 20;
//	char line[Size2];
//
//	cin.get(line, Size2);
//	cout << "�Է��Ͻ� ������ \n";
//	int space = 0;
//	for (int i = 0; line[i] != '\0'; i++) {
//		cout << line[i];
//		if (line[i] == ' ')
//			continue;
//
//		space++;
//	}
//	cout << "�Դϴ�\n";
//	cout << "�Է��Ͻ� ���忡�� ������ ������ ���ڴ�" << space << "���Դϴ�\n";
//
//	
//	return 0;
//}