def sum_two_smallest_numbers(numbers):
    number = min(numbers)
    numbers.remove(number)
    number2 = min(numbers)
    return number + number2