import math


n = int(input("Введите количество чисел: "))
numbers = []


for i in range(n):
    num = int(input(f"Введите число {i + 1}: "))
    numbers.append(num)


print(f"Среднее значение: {sum(numbers) / n}")
print(f"Округление в меньшую сторону: {math.floor(sum(numbers) / n)}")
print(f"Округление в большую сторону: {math.ceil(sum(numbers) / n)}")
