#!/usr/bin/env python
# -*- coding: utf-8 -*-

someList = [0, 1]

def uniFib(n):
    ''' Программа расчета последовательности фибоначчи '''
    for x in xrange(1, n):
        someList.append(someList[x] + someList[x-1])
    return someList

print uniFib.__doc__
print " "
print " {0}".format(uniFib(23))
print " "

