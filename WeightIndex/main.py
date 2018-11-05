# -*- coding: utf-8 -*-
from bmi import BMI

def main():
    """ starting point """
    while True:
            _input = input('height (m) and weight (kg) or e(xit): ').split()
            if len(_input) == 2:
                try:
                    _bmi = BMI(float(_input[0]), float(_input[1]))
                    print(f'{_bmi.calculate():.2f}', 
                          ' for a non athlete adult 20-60 with normal body that is ', 
                           _bmi.analyze())
                except ValueError:
                    print('check the input')
            elif len(_input) == 1 and _input[0].lower() == 'e':
                    break
                
if __name__ == "__main__":
    main()
    