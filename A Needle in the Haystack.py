def find_needle(haystack):
    # your code here
    
    for string in haystack:   
        if string == "needle":
            needleIndex = haystack.index("needle")
            return( "found the needle at position " + str(needleIndex))