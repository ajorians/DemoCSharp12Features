int[] a = new int[]{ 1,2,3,4};

Span<int> b = ['a', 'b', 'c'];

int[][] twoD = [[1,2,3],
   [4,5,6],
   [7,8,9]];

int[] row0 = [1,2,3];
int[] row1 = [1,2,3];
int[] row2 = [1,2,3];
int[] twoDFromVariables = [..row0, ..row1, ..row2];

Dictionary<string, int> myDictionary = [];
