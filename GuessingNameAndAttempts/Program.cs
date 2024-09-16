using namespace std;

int main() {
    int number = 0;
    cout << "Enter a number greater than 0: ";
    cin >> number;

    while (number <= 0) {
        cout << "Number must be greater than 0. Enter again: ";
        cin >> number;
    }

    cout << "You entered: " << number << endl;
    return 0;
}
