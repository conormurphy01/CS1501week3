#leetcode solution

class Solution(object):
    def twoSum(nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        for i in range(len(nums)):
            for n in range(i+1, len(nums)):
                if nums[i] + nums[n] == target:
                    return [i, n]
