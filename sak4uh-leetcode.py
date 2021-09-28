# Sam Klein, sak4uh
def isPalindrome(x: int) -> bool:
    if x < 0:
        return False
    original = x
    reverse = 0
    while original:
        reverse = reverse * 10 + original % 10
        original //= 10
    return x == reverse