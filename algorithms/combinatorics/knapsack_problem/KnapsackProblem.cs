using System;
using System.Collections.Generic;

public static partial class Algorithms{
    public static int[,] MakeKnapsackMatrix(List<Tuple<int, int>> items, int maxWeight){
        int[,] choosesTable = new int[items.Count + 1, maxWeight + 1];

        for(int totalItems = 0; totalItems <= items.Count; ++totalItems){
            for(int subMaxWeight = 0; subMaxWeight <= maxWeight; ++subMaxWeight){

                int currentItem = totalItems - 1;

                if(totalItems == 0 || subMaxWeight == 0){
                    choosesTable[totalItems, subMaxWeight] = 0;
                }

                else if(items[currentItem].Item1 > subMaxWeight){
                    choosesTable[totalItems, subMaxWeight] = choosesTable[totalItems - 1, subMaxWeight];
                }

                else{
                    int itemWeight = items[currentItem].Item1;
                    int itemValue = items[currentItem].Item2;

                    int withItem = itemValue + choosesTable[totalItems - 1, subMaxWeight - itemWeight];
                    int withoutItem = choosesTable[totalItems - 1, subMaxWeight];

                    choosesTable[totalItems, subMaxWeight] = Math.Max(withItem, withoutItem);
                }
            }
        }

        return choosesTable;
    }

    public static int MaxKnapsackValue(List<Tuple<int, int>> items, int maxWeight){
        int[,] choosesTable = MakeKnapsackMatrix(items, maxWeight);

        return choosesTable[items.Count, maxWeight];
    }

    public static bool[] KnapsackItems(List<Tuple<int, int>> items, int maxWeight){
        int[,] choosesTable = MakeKnapsackMatrix(items, maxWeight);
        int maxValue = choosesTable[items.Count, maxWeight];

        bool[] whichItems = new bool[items.Count + 1];

        for(int i = 0; i < whichItems.Length; ++i){
            whichItems[i] = false;
        }

        int y = items.Count;
        int x = maxWeight;

        while(maxValue > 0){

            while((choosesTable[y - 1, x] == choosesTable[y, x]) && y > 0){
                y--;
            }

            y--;

            whichItems[y] = true;
            maxValue -= items[y].Item2;

            if(maxValue == 0){
                break;
            }

            while((choosesTable[y, x - 1] >= maxValue) && x > 0){
                x--;
            }
        }

        return whichItems;
    }
}