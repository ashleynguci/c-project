# -*- coding: utf-8 -*-
"""
BMI
"""
class BMI:
    """ calculates weight  index """
    def __init__(self, _height, _length):
        self.__height = _height
        self.__length = _length

    def calculate(self):
        self.__index = self.__length / self.__height / self.__height
        return self.__index
    
    def analyze(self):
        if self.__index <= 16.0:
            tulos = "severe underweight"
        elif self.__index > 16.0 and self.__index <= 17.0:
            tulos = "underweight"
        elif self.__index > 17.0 and self.__index <= 18.5:
            tulos = "mild underweightLievä alipaino"
        elif self.__index > 18.5 and self.__index <= 25.0:
            tulos = "normal"
        elif self.__index > 25.0 and self.__index <= 30.0:
            tulos = "mild overweight"
        elif self.__index > 30.0 and self.__index <= 35.0:
            tulos = "overweight  "
        elif self.__index > 35.0 and self.__index <= 40.0:
            tulos = "severe overweight"
        elif self.__index > 40.0:
            tulos = "severe obesity"
        return tulos
