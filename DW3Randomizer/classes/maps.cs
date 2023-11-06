using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW3Randomizer.classes
{



    public class maps
    {
        private class BridgeList
        {
            public int x;
            public int y;
            public bool south;
            public int distance;
            public int island1;
            public int island2;

            public BridgeList(int pX, int pY, bool pS, int pDist, int pI1, int pI2)
            {
                x = pX; y = pY; south = pS; distance = pDist; island1 = pI1; island2 = pI2;
            }
        }

        private class islandLinks
        {
            public int island1;
            public int island2;

            public islandLinks(int pI1, int pI2)
            {
                island1 = pI1; island2 = pI2;
            }
        }

        private bool checkRandoMap(ref int[,] maplocs, int y, int x, int maxY, int maxX)
        {
            int locsum = 0;
            for (int lnX = 0; lnX < maxX; lnX++)
                for (int lnY = 0; lnY < maxY; lnY++)
                    if (maplocs[x + lnX, y + lnY] == 1)
                        locsum += 1;
            if (locsum == 0)
                return true;
            else
                return false;
        }

        private void createBridges(ref Random r1, ref int[,] map, ref int[,] map2, ref int[,] island, ref int[,] island2)
        {
            List<BridgeList> bridgePossible = new List<BridgeList>();
            List<islandLinks> islandPossible = new List<islandLinks>();
            // Create bridges for points two spaces or less from two distinctly numbered islands.  Extend islands if there is interference.
            // 0x00 = Water (was 0x04 in DW2)
            // 0x06 = Mountain (was 0x05 in DW2)
            for (int y = 1; y < 252; y++)
                for (int x = 1; x < 252; x++)
                {
                    if (y == 63 && x == 8) map[y, x] = map[y, x];
                    if (map[y, x] == 0x06 || map[y, x] == 0x00) continue;

                    for (int lnI = 2; lnI <= 4; lnI++)
                    {
                        if (island[y, x] != island[y + lnI, x] && island[y, x] / 1000 == island[y + lnI, x] / 1000 && map[y + lnI, x] != 0x00 && map[y + lnI, x] != 0x06)
                        {
                            bool fail = false;
                            for (int lnJ = 1; lnJ < lnI; lnJ++)
                            {
                                if (map[y + lnJ, x] == 0x00)
                                {
                                    map[y + lnJ, x - 1] = 0x00; map[y + lnJ, x + 1] = 0x00;
                                    island[y + lnJ, x - 1] = 0x00; island[y + lnJ, x + 1] = 0x00;
                                }
                                else
                                {
                                    fail = true;
                                }
                            }
                            if (!fail)
                            {
                                bridgePossible.Add(new BridgeList(x, y, true, lnI, island[y, x], island[y + lnI, x]));
                                int[,] tempisland = island;
                                if (islandPossible.Where(c => c.island1 == tempisland[y, x] && c.island2 == tempisland[y + lnI, x]).Count() == 0)
                                    islandPossible.Add(new islandLinks(island[y, x], island[y + lnI, x]));
                            }
                        }

                        if (island[y, x] != island[y, x + lnI] && island[y, x] / 1000 == island[y, x + lnI] / 1000 && map[y, x + lnI] != 0x00 && map[y, x + lnI] != 0x06)
                        {
                            bool fail = false;
                            for (int lnJ = 1; lnJ < lnI; lnJ++)
                            {
                                if (map[y, x + lnJ] == 0x00)
                                {
                                    map[y - 1, x + lnJ] = 0x00; map[y + 1, x + lnJ] = 0x00;
                                    island[y - 1, x + lnJ] = 200; island[y + 1, x + lnJ] = 200;
                                }
                                else
                                {
                                    fail = true;
                                }
                            }
                            if (!fail)
                            {
                                bridgePossible.Add(new BridgeList(x, y, false, lnI, island[y, x], island[y, x + lnI]));
                                int[,] tempisland = island;
                                if (islandPossible.Where(c => c.island1 == tempisland[y, x] && c.island2 == tempisland[y, x + lnI]).Count() == 0)
                                    islandPossible.Add(new islandLinks(island[y, x], island[y, x + lnI]));
                            }
                        }
                    }
                }

            foreach (islandLinks islandLink in islandPossible)
            {
                List<BridgeList> test = bridgePossible.Where(c => c.island1 == islandLink.island1 && c.island2 == islandLink.island2).ToList();
                // Choose one bridge out of the possibilities
                BridgeList bridgeToBuild = test[r1.Next() % test.Count];
                for (int lnI = 1; lnI <= bridgeToBuild.distance - 1; lnI++)
                {
                    if (bridgeToBuild.south)
                    {
                        map[bridgeToBuild.y + lnI, bridgeToBuild.x] = (lnI == bridgeToBuild.distance - 1 ? 0xff : map[bridgeToBuild.y, bridgeToBuild.x]);
                        island[bridgeToBuild.y + lnI, bridgeToBuild.x] = bridgeToBuild.island1;

                        if (map[bridgeToBuild.y + lnI + 1, bridgeToBuild.x] == 0x00 && lnI == bridgeToBuild.distance - 1)
                        {
                            bridgeToBuild.distance++;
                            map[bridgeToBuild.y + lnI + 1, bridgeToBuild.x - 1] = 0x00; map[bridgeToBuild.y + lnI + 1, bridgeToBuild.x + 1] = 0x00;
                            island[bridgeToBuild.y + lnI + 1, bridgeToBuild.x - 1] = 0x00; island[bridgeToBuild.y + lnI + 1, bridgeToBuild.x + 1] = 0x00;
                        }
                    }
                    else
                    {
                        map[bridgeToBuild.y, bridgeToBuild.x + lnI] = (lnI == bridgeToBuild.distance - 1 ? 0xfb : map[bridgeToBuild.y, bridgeToBuild.x]);
                        island[bridgeToBuild.y, bridgeToBuild.x + lnI] = bridgeToBuild.island1;

                        if (map[bridgeToBuild.y, bridgeToBuild.x + lnI + 1] == 0x00 && lnI == bridgeToBuild.distance - 1)
                        {
                            bridgeToBuild.distance++;
                            map[bridgeToBuild.y - 1, bridgeToBuild.x + lnI + 1] = 0x00; map[bridgeToBuild.y + 1, bridgeToBuild.x + lnI + 1] = 0x00;
                            island[bridgeToBuild.y - 1, bridgeToBuild.x + lnI + 1] = 200; island[bridgeToBuild.y + 1, bridgeToBuild.x + lnI + 1] = 200;
                        }
                    }
                }
            }
        }

        private bool createZone(int zoneNumber, int size, bool rectangle, ref Random r1, ref int[,] zone)
        {
            int tries = 1000;
            bool firstZone = true;

            if (!rectangle)
            {
                while (size > 0 && tries > 0)
                {
                    int x = r1.Next() % 16;
                    int y = r1.Next() % 16;
                    int minX = x, maxX = x, minY = y, maxY = y;
                    if (!firstZone && zone[y, x] != zoneNumber)
                    {
                        continue;
                    }
                    if (firstZone)
                    {
                        firstZone = false;
                        zone[y, x] = zoneNumber;
                    }

                    tries--;
                    int direction = r1.Next() % 16;
                    int totalDirections = 0;
                    if (direction % 16 >= 8) totalDirections++;
                    if (direction % 8 >= 4) totalDirections++;
                    if (direction % 4 >= 2) totalDirections++;
                    if (direction % 2 >= 1) totalDirections++;
                    if (totalDirections > size) continue;

                    // 1 = north, 2 = east, 4 = south, 8 = west
                    if (direction % 16 >= 8 && x != 0 && zone[y, x - 1] == 0 && (minX <= (x - 1) || maxX - minX <= 11))
                    {
                        zone[y, x - 1] = zoneNumber;
                        minX = (x - 1 < minX ? x - 1 : minX);
                        size--;
                        tries = 100;
                    }
                    if (direction % 8 >= 4 && y != 15 && zone[y + 1, x] == 0 && (maxY >= (y + 1) || maxY - minY <= 11))
                    {
                        zone[y + 1, x] = zoneNumber;
                        maxY = (y + 1 > maxY ? y + 1 : maxY);
                        size--;
                        tries = 100;
                    }
                    if (direction % 4 >= 2 && x != 15 && zone[y, x + 1] == 0 && (minX >= (x + 1) || maxX - minX <= 11))
                    {
                        zone[y, x + 1] = zoneNumber;
                        maxX = (x + 1 > maxX ? x + 1 : maxX);
                        size--;
                        tries = 100;
                    }
                    if (direction % 2 >= 1 && y != 0 && zone[y - 1, x] == 0 && (minY <= (y - 1) || maxY - minY <= 11))
                    {
                        zone[y - 1, x] = zoneNumber;
                        minY = (y - 1 < minY ? y - 1 : minY);
                        size--;
                        tries = 100;
                    }
                }
                return (size <= 0);
            }
            else
            {
                int minMeasurement = (int)Math.Ceiling((double)size / 12);
                int maxMeasurement = (int)Math.Ceiling((double)size / minMeasurement);

                int length = ((r1.Next() % (maxMeasurement - minMeasurement)) + minMeasurement);
                int width = size / length;

                int x = (r1.Next() % (16 - length));
                int y = (r1.Next() % (16 - width));

                for (int i = x; i < x + length; i++)
                    for (int j = y; j < y + width; j++)
                        zone[j, i] = zoneNumber;

                return true;
            }
        }

        private void generateZoneMap(int zoneToUse, int islandSize, ref Random r1, bool debugmode, bool smallMap, ref int[,] map, ref int[,] map2, ref int[,] island, ref int[,] island2, ref int[,] zone,
            ref int[] maxIsland, ref List<int> islands, string txtFileName, string txtSeed, string txtFlags)
        {
            int xMax = (zoneToUse != -1000 ? (smallMap ? 128 : 256) : (smallMap ? 80 : 136)) - 7;
            int yMax = (zoneToUse != -1000 ? (smallMap ? 128 : 256) : (smallMap ? 80 : 132)) - 7;
            int yMin = 6;
            int xMin = 6;

            int[] terrainTypes = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 7 };

            for (int lnI = 0; lnI < 100; lnI++)
            {
                int swapper1 = r1.Next() % terrainTypes.Length;
                int swapper2 = r1.Next() % terrainTypes.Length;
                int temp = terrainTypes[swapper1];
                terrainTypes[swapper1] = terrainTypes[swapper2];
                terrainTypes[swapper2] = temp;
            }

            int lnMarker = -1;
            int totalLand = 0;
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + ".txt")))
                    writer2.WriteLine("zoneToUse = " + zoneToUse);
            }
            while (totalLand < islandSize)
            {
                if (debugmode)
                {
                    using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + ".txt")))
                        writer2.WriteLine("totalLand = " + totalLand + " Island Size = " + islandSize);
                }
                lnMarker++;
                lnMarker = (lnMarker >= terrainTypes.Length ? 0 : lnMarker);
                int sizeToUse = (r1.Next() % 400) + 150;
                if (debugmode)
                {
                    using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + ".txt")))
                        writer2.WriteLine("sizetouse1 = " + sizeToUse);
                }

                //if (terrainTypes[lnMarker] == 5) sizeToUse /= 2;

                List<int> points = new List<int> { (r1.Next() % (xMax - xMin)) + xMin, (r1.Next() % (yMax - yMin)) + yMin };
                if (validPoint(points[0], points[1], zoneToUse, smallMap, ref zone))
                {
                    while (sizeToUse > 0)
                    {
                        if (debugmode)
                        {
                            using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + ".txt")))
                                writer2.WriteLine("sizetouse2 = " + sizeToUse);
                        }
                        List<int> newPoints = new List<int>();
                        for (int lnI = 0; lnI < points.Count; lnI += 2)
                        {
                            int lnX = points[lnI];
                            int lnY = points[lnI + 1];

                            //                            if (lnX == 127 && lnY == 56) lnX = lnX; // Why redeclare?

                            int direction = (r1.Next() % 16);
                            if (zoneToUse != -1000)
                            {
                                map[lnY, lnX] = terrainTypes[lnMarker];
                                island[lnY, lnX] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
                            }
                            else
                            {
                                map2[lnY, lnX] = terrainTypes[lnMarker];
                                island2[lnY, lnX] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
                            }

                            // 1 = North, 2 = east, 4 = south, 8 = west
                            if (direction % 8 >= 4 && lnY <= yMax)
                            {
                                if (validPoint(lnX, lnY + 1, zoneToUse, smallMap, ref zone))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY + 1, lnX] == 0)
                                            totalLand++;
                                        map2[lnY + 1, lnX] = terrainTypes[lnMarker];
                                        island2[lnY + 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
                                    }
                                    else
                                    {
                                        if (map[lnY + 1, lnX] == 0)
                                            totalLand++;
                                        map[lnY + 1, lnX] = terrainTypes[lnMarker];
                                        island[lnY + 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
                                    }

                                    newPoints.Add(lnX);
                                    newPoints.Add(lnY + 1);
                                }
                            }
                            if (direction % 2 >= 1 && lnY >= yMin)
                            {
                                if (validPoint(lnX, lnY - 1, zoneToUse, smallMap, ref zone))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY - 1, lnX] == 0)
                                            totalLand++;
                                        map2[lnY - 1, lnX] = terrainTypes[lnMarker];
                                        island2[lnY - 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
                                    }
                                    else
                                    {
                                        if (map[lnY - 1, lnX] == 0)
                                            totalLand++;
                                        map[lnY - 1, lnX] = terrainTypes[lnMarker];
                                        island[lnY - 1, lnX] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
                                    }
                                    newPoints.Add(lnX);
                                    newPoints.Add(lnY - 1);
                                }
                            }
                            if (direction % 4 >= 2 && lnX <= xMax)
                            {
                                if (validPoint(lnX + 1, lnY, zoneToUse, smallMap, ref zone))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY, lnX + 1] == 0)
                                            totalLand++;
                                        map2[lnY, lnX + 1] = terrainTypes[lnMarker];
                                        island2[lnY, lnX + 1] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
                                    }
                                    else
                                    {
                                        if (map[lnY, lnX + 1] == 0)
                                            totalLand++;
                                        map[lnY, lnX + 1] = terrainTypes[lnMarker];
                                        island[lnY, lnX + 1] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
                                    }
                                    newPoints.Add(lnX + 1);
                                    newPoints.Add(lnY);
                                }
                            }
                            if (direction % 16 >= 8 && lnX >= xMin)
                            {
                                if (validPoint(lnX - 1, lnY, zoneToUse, smallMap, ref zone))
                                {
                                    if (zoneToUse == -1000)
                                    {
                                        if (map2[lnY, lnX - 1] == 0)
                                            totalLand++;
                                        map2[lnY, lnX - 1] = terrainTypes[lnMarker];
                                        island2[lnY, lnX - 1] = (terrainTypes[lnMarker] == 6 ? -1 : 0);
                                    }
                                    else
                                    {
                                        if (map[lnY, lnX - 1] == 0)
                                            totalLand++;
                                        map[lnY, lnX - 1] = terrainTypes[lnMarker];
                                        island[lnY, lnX - 1] = (terrainTypes[lnMarker] == 6 ? -1 - zoneToUse : zoneToUse);
                                    }
                                    newPoints.Add(lnX - 1);
                                    newPoints.Add(lnY);
                                }
                            }

                            int takeaway = 1 + (direction > 8 ? 1 : 0) + (direction % 8 > 4 ? 1 : 0) + (direction % 4 > 2 ? 1 : 0) + (direction % 2 > 1 ? 1 : 0);
                            sizeToUse--;
                        }
                        //if (sizeToUse <= 0) break;
                        if (newPoints.Count != 0)
                            points = newPoints;
                    }
                }
            }

            // Fill in water...
            List<int> land = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            if (zoneToUse != -1000)
            {
                for (int lnY = 0; lnY < 256; lnY++)
                    for (int lnX = 0; lnX < 256; lnX++)
                    {
                        if (island[lnY, lnX] == zoneToUse && island[lnY, lnX + 1] == zoneToUse && island[lnY, lnX + 2] == zoneToUse && island[lnY, lnX + 3] == zoneToUse)
                        {
                            if (map[lnY, lnX] == map[lnY, lnX + 2] && map[lnY, lnX] != map[lnY, lnX + 1])
                            {
                                map[lnY, lnX + 1] = map[lnY, lnX];
                                island[lnY, lnX + 1] = island[lnY, lnX];
                            }
                            if (lnX < 254 && land.Contains(map[lnY, lnX]) && !land.Contains(map[lnY, lnX + 1]) && !land.Contains(map[lnY, lnX + 2]) && land.Contains(map[lnY, lnX + 3]))
                            {
                                map[lnY, lnX + 1] = map[lnY, lnX];
                                map[lnY, lnX + 2] = map[lnY, lnX + 3];
                                island[lnY, lnX + 1] = island[lnY, lnX];
                                island[lnY, lnX + 2] = island[lnY, lnX + 3];
                            }
                        }
                    }

                markIslands(ref map, ref map2, ref island, ref island2, ref islands, ref maxIsland, zoneToUse);
            }
            else
            {
                for (int lnY = 0; lnY < 136; lnY++)
                    for (int lnX = 0; lnX < 156; lnX++)
                    {
                        if (map2[lnY, lnX] == map2[lnY, lnX + 2] && map2[lnY, lnX] != map2[lnY, lnX + 1])
                        {
                            map2[lnY, lnX + 1] = map2[lnY, lnX];
                            island2[lnY, lnX + 1] = island2[lnY, lnX];
                        }
                        if (lnX < 149 && land.Contains(map2[lnY, lnX]) && !land.Contains(map2[lnY, lnX + 1]) && !land.Contains(map2[lnY, lnX + 2]) && land.Contains(map2[lnY, lnX + 3]))
                        {
                            map2[lnY, lnX + 1] = map2[lnY, lnX];
                            map2[lnY, lnX + 2] = map2[lnY, lnX + 3];
                            island2[lnY, lnX + 1] = island2[lnY, lnX];
                            island2[lnY, lnX + 2] = island2[lnY, lnX + 3];
                        }
                    }
            }
        }

        private int lakePlot(ref int[,] map, ref int[,] island, int lakeNumber, int y, int x, bool fill = false, int islandNumber = -1)
        {
            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 1;
            //if (islandNumber >= 0) plots = 1;
            while (first || toPlot.Count != 0)
            {
                if (!first)
                {
                    y = toPlot[0];
                    toPlot.RemoveAt(0);
                    x = toPlot[0];
                    toPlot.RemoveAt(0);
                }
                else
                {
                    if (fill)
                        map[y, x] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);
                    first = false;
                }

                for (int dir = 0; dir < 5; dir++)
                {
                    int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                    dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
                    int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                    dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

                    if (island[dirY, dirX] == -1 || (island[dirY, dirX] == lakeNumber && fill))
                    {
                        plots++;
                        island[dirY, dirX] = (fill ? islandNumber : lakeNumber);
                        if (fill)
                            map[dirY, dirX] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);

                        if (dir != 0)
                        {
                            toPlot.Add(dirY);
                            toPlot.Add(dirX);
                        }
                        //plots += lakePlot(lakeNumber, y, x, fill);
                    }
                }
            }

            return plots;
        }

        private int lakePlot2(ref int[,] map2, ref int[,] island2, int lakeNumber, int y, int x, bool fill = false, int islandNumber = -1)
        {
            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 1;
            //if (islandNumber >= 0) plots = 1;
            while (first || toPlot.Count != 0)
            {
                if (!first)
                {
                    y = toPlot[0];
                    toPlot.RemoveAt(0);
                    x = toPlot[0];
                    toPlot.RemoveAt(0);
                }
                else
                {
                    if (fill)
                        map2[y, x] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);
                    first = false;
                }

                for (int dir = 0; dir < 5; dir++)
                {
                    int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                    dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
                    int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                    dirY = (dirY == 139 ? 0 : dirY == -1 ? 138 : dirY);

                    if (island2[dirY, dirX] == -1 || (island2[dirY, dirX] == lakeNumber && fill))
                    {
                        plots++;
                        island2[dirY, dirX] = (fill ? islandNumber : lakeNumber);
                        if (fill)
                            map2[dirY, dirX] = (islandNumber == 0 ? 0x02 : islandNumber == 1 ? 0x03 : islandNumber == 2 ? 0x04 : islandNumber == 3 ? 0x01 : 0x05);

                        if (dir != 0)
                        {
                            toPlot.Add(dirY);
                            toPlot.Add(dirX);
                        }
                        //plots += lakePlot(lakeNumber, y, x, fill);
                    }
                }
            }

            return plots;
        }

        private int landPlot(ref int[,] island, ref int[,] island2, int landNumber, int y, int x, int zoneToUse = 0)
        {
            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 1;
            while (first || toPlot.Count != 0)
            {
                if (!first)
                {
                    y = toPlot[0];
                    toPlot.RemoveAt(0);
                    x = toPlot[0];
                    toPlot.RemoveAt(0);
                }
                else
                {
                    first = false;
                }

                for (int dir = 0; dir < 5; dir++)
                {
                    if (zoneToUse != -1000)
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

                        if (island[dirY, dirX] == zoneToUse)
                        {
                            plots++;
                            island[dirY, dirX] = landNumber;

                            if (dir != 0)
                            {
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                            }
                        }
                    }
                    else
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 138 ? 0 : dirY == -1 ? 137 : dirY);

                        if (island2[dirY, dirX] == 0)
                        {
                            plots++;
                            island2[dirY, dirX] = landNumber;

                            if (dir != 0)
                            {
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                            }
                        }
                    }
                }
            }

            return plots;
        }

        private void markIslands(ref int[,] map, ref int[,] map2, ref int[,] island, ref int[,] island2, ref List<int> islands, ref int[] maxIsland, int zoneToUse)
        {
            if (zoneToUse != -1000)
            {
                // We should mark islands and inaccessible land...
                int landNumber = zoneToUse + 1;
                int maxLand = -2;

                int maxLandPlots = 0;
                int lastIsland = 0;
                for (int lnI = 0; lnI < 256; lnI++)
                    for (int lnJ = 0; lnJ < 256; lnJ++)
                    {
                        if (island[lnI, lnJ] == zoneToUse && map[lnI, lnJ] != 0x06)
                        {
                            int plots = landPlot(ref island, ref island2, landNumber, lnI, lnJ, zoneToUse);
                            if (plots > maxLandPlots)
                            {
                                maxLandPlots = plots;
                                maxLand = landNumber;
                            }
                            islands.Add(landNumber);
                            landNumber++;

                            lastIsland = island[lnI, lnJ];
                        }
                    }

                maxIsland[zoneToUse / 1000] = maxLand;
            }
            else
            {
                // We should mark islands and inaccessible land...
                int landNumber = 1;

                for (int lnI = 0; lnI < 139; lnI++)
                    for (int lnJ = 0; lnJ < 158; lnJ++)
                    {
                        if (island2[lnI, lnJ] == 0 && map2[lnI, lnJ] != 0x06)
                        {
                            int plots = landPlot(ref island, ref island2, landNumber, lnI, lnJ, zoneToUse);
                            landNumber++;
                        }
                    }
            }
        }

        private void markZoneSides(ref int[,] zone)
        {
            for (int x = 0; x < 16; x++)
                for (int y = 0; y < 16; y++)
                {
                    // 1 = north, 2 = east, 4 = south, 8 = west
                    if (y == 0) zone[y, x] += 1;
                    else if (zone[y - 1, x] / 1000 != zone[y, x] / 1000) zone[y, x] += 1;

                    if (x == 15) zone[y, x] += 2;
                    else if (zone[y, x + 1] / 1000 != zone[y, x] / 1000) zone[y, x] += 2;

                    if (y == 15) zone[y, x] += 4;
                    else if (zone[y + 1, x] / 1000 != zone[y, x] / 1000) zone[y, x] += 4;

                    if (x == 0) zone[y, x] += 8;
                    else if (zone[y, x - 1] / 1000 != zone[y, x] / 1000) zone[y, x] += 8;
                }
        }

        private int randoCont(ref Random r1, int contcase)
        {
            // Case 0 = Cont 0, Case 1 = Cont 1, Case 2 = Cont 2, Case 3 = Cont 0, 1, 2, Case 4 = Cont 1, 2, Case 5 = Cont 0, 1, 2, 9
            int returnnum = 0;

            switch (contcase)
            {
                case 0:
                    returnnum = 0;
                    break;
                case 1:
                    returnnum = 1;
                    break;
                case 2:
                    returnnum = 2;
                    break;
                case 3:
                    returnnum = r1.Next() % 6;
                    if (returnnum == 0)
                        returnnum = 1;
                    else if (returnnum <= 2)
                        returnnum = 2;
                    else
                        returnnum = 0;
                    break;
                case 4:
                    returnnum = r1.Next() % 3;
                    if (returnnum == 0)
                        returnnum = 1;
                    else
                        returnnum = 2;
                    break;
                case 5:
                    returnnum = r1.Next() % 10;
                    if (returnnum == 0)
                        returnnum = 1;
                    else if (returnnum <= 2)
                        returnnum = 2;
                    else if (returnnum <= 5)
                        returnnum = 0;
                    else
                        returnnum = 9;
                    break;
            }
            return returnnum;
        }

        public void randomizeMapv5(ref byte[] romData, ref Random r1, ref bool randMap, ref int[,] map, ref int[,] map2, ref int[,] island, ref int[,] island2, ref int[,] zone, ref int[] maxIsland, ref List<int> islands,
            ref int[,] maplocs, ref bool disAlefgardGlitch, bool debugmode, string versionNumber, string txtFileName, string txtSeed, string txtFlags, bool smallMap, bool GenIslandsMonstersZones, int RandTowns, int RandCaves,
            int RandShrines, int BaramosCast, int DisAlefGlitch, int Charlock, int LancelCave, int DrgQnCast, int CaveOfNecro, int NoNewTown)
        {
            string shortVersion = versionNumber.Replace(".", "");
            if (debugmode)
            {
                using (StreamWriter writer2 = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("Enter Randomize Map");
            }
            randMap = true;

            for (int lnI = 0; lnI < 256; lnI++)
                for (int lnJ = 0; lnJ < 256; lnJ++)
                {
                    if (smallMap && (lnI >= 128 || lnJ >= 128))
                    {
                        map[lnI, lnJ] = 0x06;
                        island[lnI, lnJ] = 200;
                    }
                    else
                    {
                        map[lnI, lnJ] = 0x00;
                        island[lnI, lnJ] = -1;
                    }
                }

            for (int lnI = 0; lnI < 139; lnI++)
                for (int lnJ = 0; lnJ < 158; lnJ++)
                {
                    map2[lnI, lnJ] = 0x00;
                    island2[lnI, lnJ] = -1;
                }

            for (int lnI = 0; lnI < 132; lnI++)
                for (int lnJ = 0; lnJ < 156; lnJ++)
                    map2[lnI, lnJ] = 0x00;


            int smallIslandSize = (r1.Next() % 16000) + 18000; // (lnI == 0 ? 1500 : lnI == 1 ? 2500 : lnI == 2 ? 1500 : lnI == 3 ? 1500 : lnI == 4 ? 5000 : 5000);
            int bigIslandSize = (r1.Next() % 10000) + 30000; // (lnI == 0 ? 1500 : lnI == 1 ? 2500 : lnI == 2 ? 1500 : lnI == 3 ? 1500 : lnI == 4 ? 5000 : 5000);
                                                             //            int islandSize2 = (chkSmallMap.Checked ? (r1.Next() % 1800) + 2400 : (r1.Next() % 3000) + 11000); // For Tantegel
            int islandSize2 = (r1.Next() % 3000) + 11000; // For Tantegel

            smallIslandSize /= (smallMap ? 4 : 1);
            bigIslandSize /= (smallMap ? 4 : 1);
            islandSize2 /= (smallMap ? 4 : 1);

            // Set up three special zones.  Zone 1000 = 20 squares and has Thief key stuff.  Zone 2000 = 40 squares and has Magic Key stuff.
            // Zone 3000 = 1 square and has Baramos stuff and end of Necrogund stuff.  It will be surrounded by one tile of mountains.
            // This takes up 94 / 256 of the total squares available.

            bool zonesCreated = false;
            List<int> noradLink = new List<int>();

            while (!zonesCreated)
            {
                zone = new int[16, 16];
                if (createZone(1000, 25, false, ref r1, ref zone) && createZone(2000, 50, false, ref r1, ref zone))
                    zonesCreated = true;
            }
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("Zones Created");
            }

            markZoneSides(ref zone);
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("ZoneSides");
            }

            generateZoneMap(1000, bigIslandSize * 25 / 256, ref r1, debugmode, smallMap, ref map, ref map2, ref island, ref island2, ref zone, ref maxIsland, ref islands, txtFileName, txtSeed, txtFlags); // Aliahan Castle is here.
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("1000");
            }

            generateZoneMap(2000, bigIslandSize * 50 / 256, ref r1, debugmode, smallMap, ref map, ref map2, ref island, ref island2, ref zone, ref maxIsland, ref islands, txtFileName, txtSeed, txtFlags); // Romaly Castle is here.
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("2000");
            }

            generateZoneMap(0, smallIslandSize * 170 / 256, ref r1, debugmode, smallMap, ref map, ref map2, ref island, ref island2, ref zone, ref maxIsland, ref islands, txtFileName, txtSeed, txtFlags); // Norud Cave East is here.
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("0");
            }

            generateZoneMap(-1000, islandSize2, ref r1, debugmode, smallMap, ref map, ref map2, ref island, ref island2, ref zone, ref maxIsland, ref islands, txtFileName, txtSeed, txtFlags); // About 31% of the regular map
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("-1000");
            }

            smoothMap(ref map, ref island);
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("smoothMap");
            }

            smoothMap2(ref map2, ref island2);
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("smoothMap2");
            }

            createBridges(ref r1, ref map, ref map2, ref island, ref island2);
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("Create Bridges");
            }

            resetIslands(ref map, ref map2, ref island, ref island2, ref maxIsland, ref islands);
            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("Reset Islands");
            }

            // We should mark islands and inaccessible land...
            int lakeNumber = 256;

            int maxPlots = 0;
            int maxLake = 0;
            int lastValidIsland = -1;

            for (int lnI = 0; lnI < 256; lnI++)
                for (int lnJ = 0; lnJ < 256; lnJ++)
                {
                    if (island[lnI, lnJ] == -1)
                    {
                        int plots = lakePlot(ref map, ref island, lakeNumber, lnI, lnJ);
                        if (plots > maxPlots)
                        {
                            maxPlots = plots;
                            maxLake = lakeNumber;
                        }
                        lakeNumber++;
                    }
                    else
                    {
                        lastValidIsland = island[lnI, lnJ];
                    }
                }

            lakeNumber = 4256;
            maxPlots = 0;
            int maxLake2 = 0;
            lastValidIsland = -1;

            for (int lnI = 0; lnI < 139; lnI++)
                for (int lnJ = 0; lnJ < 158; lnJ++)
                {
                    if (island2[lnI, lnJ] == -1)
                    {
                        int plots = lakePlot2(ref map2, ref island2, lakeNumber, lnI, lnJ);
                        if (plots > maxPlots)
                        {
                            maxPlots = plots;
                            maxLake2 = lakeNumber;
                        }
                        lakeNumber++;
                    }
                    else
                    {
                        lastValidIsland = island[lnI, lnJ];
                    }
                }

            if (GenIslandsMonstersZones == true)
            {
                string shortVersion2 = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "island_" + txtSeed + "_" + txtFlags + "_" + shortVersion2 + ".txt")))
                {
                    for (int lnY = 0; lnY < 139; lnY++)
                    {
                        string output = "";
                        for (int lnX = 0; lnX < 158; lnX++)
                            output += island2[lnY, lnX].ToString().PadLeft(5);
                        writer.WriteLine(output);
                    }
                }
            }

            // Establish Aliahan location
            bool midenOK = false;
            int[] midenX = new int[7];
            int[] midenY = new int[7];

            while (!midenOK)
            {
                midenX[1] = 6 + (r1.Next() % (smallMap ? 116 : 244));
                midenY[1] = 6 + (r1.Next() % (smallMap ? 116 : 244));
                if (validPlot(ref map, ref map2, ref island,  smallMap, midenY[1], midenX[1], 2, 4, new int[] { maxIsland[1] }))
                    midenOK = true;
            }

            // Shrine South Of Romaly
            midenOK = false;
            while (!midenOK)
            {
                midenX[2] = 6 + (r1.Next() % (smallMap ? 116 : 244));
                midenY[2] = 6 + (r1.Next() % (smallMap ? 116 : 244));
                if (validPlot(ref map, ref map2, ref island, smallMap, midenY[2], midenX[2], 1, 1, new int[] { maxIsland[2] }))
                    midenOK = true;
            }

            // Norud Cave
            midenOK = false;
            while (!midenOK)
            {
                midenX[0] = 6 + (r1.Next() % (smallMap ? 116 : 244));
                midenY[0] = 6 + (r1.Next() % (smallMap ? 116 : 244));
                if (validPlot(ref map, ref map2, ref island, smallMap, midenY[0], midenX[0], 1, 1, new int[] { maxIsland[0] }))
                    midenOK = true;
            }

            // Tantegel
            midenOK = false;
            while (!midenOK)
            {
                midenX[6] = r1.Next() % 132;
                midenY[6] = r1.Next() % 132;
                if (validPlot(ref map, ref map2, ref island, smallMap, midenY[6], midenX[6], 2, 4, new int[] { 60000 }))
                    midenOK = true;
            }


            int charlockX = -255;
            int charlockY = -255;

            // Relocate opening Tantegel scene to 1, 1
            romData[0x3ceb4] = 0x01;
            romData[0x3cebf] = 0x01;
            romData[0x1b3eb] = 0x01;
            romData[0x1b3ec] = 0x01;

            // Don't include Romaly, Aliahan, or Portoga islands in future location hunting.
            //            islands.Remove(maxIsland[1]);
            //            islands.Remove(maxIsland[2]);
            //            islands.Remove(maxIsland[3]);

            /*
                        using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName.Text), "island.txt")))
                        {
                            for (int lnY = 0; lnY < 256; lnY++)
                            {
                                string output = "";
                                for (int lnX = 0; lnX < 256; lnX++)
                                    output += island[lnY, lnX].ToString().PadLeft(5) + " ";
                                writer.WriteLine(output);
                            }
                        }
            */
            string[] locTypes = { "C", "C", "C", "?",
                                  "S", "X", "T", "T",
                                  "?", "T", "?", "T",
                                  "T", "X", "T", "?",

                                  "T", "T", "T", "V",
                                  "V", "V", "V", "V",
                                  "V", "V", "V", "S",
                                  "S", "?", "S", "S",

                                  "?", "S", "S", "?",
                                  "S", "S", "S", "S",
                                  "S", "S", "S", "X",
                                  "X", "E", "E", "E",

                                  "E", "?", "?", "C",
                                  "E", "E", "?", "E",
                                  "E", "E", "E", "P",
                                  "W", "W", "W", "W",

                                  "W", "?", "?", "?",
                                  "?", "?", "?", "?",
                                  "X", "X", "X", "X",
                                  "X", "X", "X", "X",

                                  "X", "X" };
            /*
            0 - Aliahan - C, 1 - Romaly - C, 2 - Eginbear - C, 3 - Baramos - ?, 
            4 - Drought Shrine - S, 5 - XXXXXX - X, 6 - Samanao Town - T, 7 - Brecconary - T,
            8 - Charlock ?, 9 - Reeve - T, 10 - Portoga - ?, 11 - Noaniels - T, 
            12 - Assaram - T, 13 - XXXXXX - X, 14 - Baharata - T, 15 - Lancel - T, 

            16 - Cantlin - T, 17 - Rimuldar - T, 18 - Hauksness - T, 19 - Luzami - V, 
            20 - Kanave - V, 21 - Tedanki - V, 22 - Moor - V, 23 - Jipang - V
            24 - Pirate's Den - V, 25 - Soo - V, 26 - Kol - Vs, 27 - Shrine before Enticement - S, 
            28 - Shrine S. of Portoga - S, 29 - Sword Of Gaia Shrine - ?, 30 - Desert Shrine - S, 31 - Shrine south of Isis - S

            32 - Silver Orb Shrine - ?, 33 - Olivia Promenade - S, 34 - Olivia Canal Shrine - S, 35 - Dragon Queen Castle - ?, 
            36 - Jipang Shrine - S, 37 - Liamland - S, 38 - Samanao Shrine - S, 39 - Shrine North of Soo - S, 
            40 - Garinham - S, 41 - Staff of rain shrine - S, 42 Rainbow Drop Shrine - S, 43 - Portoga Shrine East - ?, 
            44 - Portoga Shrine West - X, 45 - Promontory Cave - E, 46 - Ruby Cave - E, 47 - Norud Cave West - E

            48 - Norud Cave East - E, 49 - Necrogund F5 - ?, 50 - Necrogund F1 - ?, 51 - Dhama - C, 
            52 - Kidnapper's Cave - E, 53 - Jipang Cave - E, 54 - Lancel Cave - ?, 55 - Samanao Cave - E, 
            56 - Erdrick's Cave - E, 57 - Mountain Cave B1 - E, 58 - Swamp Cave - E, 59 - Pyramid - P, 
            60 - Najimi Tower - W, 61 - Garuna Tower - W, 62 - Tower Of Arp - W, 63 - Champange Tower - W, 

            64 - Tower of Kol - W, 65 - Grass tile S of Reeve - ?, 66 - Isis - ?, 67 - Enticement Cave entrance - ?, 
            68 - Shrine south of Romaly - ?, 69 - Pirate Ship - ?, 70 - Greenland house - ?, 71 - New Town - ?, 
            72 - Reset - X, 73 - Reset - X, 74 - Reset - X, 75 - Blue Sky (Fall) - X, 
            76 - Prisoner (Fall) - X, 77 - Freeze - X, 78 - Eginbear Treasure Path (fall) - X, 79 - Sky (Fall) - X, 

            80 - Early Isis - X, 81 - Blue Sky Fall - X
            */

            List<int> locIslands = new List<int>();
            int[] locIslandsarray = { 1, 2, 9, 9,
                                      9, -100, 9, 6,
                                      -2, 1, 2, 2,
                                      2, -100, 0, 4,

                                      6, 6, 6, 9,
                                      2, 9, 9, 9,
                                      9, 9, 6, 1,
                                      9, 9, -100, 9,

                                      10, 9, 9, 9,
                                      9, 9, 9, 9,
                                      6, 6, 6, -100,
                                      -100, 1, 2, 2,

                                      0, 9, 10, 9,
                                      0, 9, 9, 9,
                                      6, 6, 6, 2,
                                      1, 0, 9, 2,

                                      6, 1, 2, 1,
                                      2, 9, 9, 9,
                                      -100, -100, -100, -100,
                                      -100, -100, -100, -100,

                                      -100, -100 };
            for (int lnI = 0; lnI < locIslandsarray.Length; lnI++)
                locIslands.Add(locIslandsarray[lnI]);

            // 9/20 - Bring locIslandsarray back out of if statement. Use r1 to randomize shrine continent (0, 1, 2, 4). Make Portoga shrine on 1,2.
            // Add option for Randomizing Towns (only towns that won't break forward progress)
            // Add option for Randomizing Caves (only caves that won't break forward progress)
            bool shrineRando = false;
            bool caveRando = false;
            bool townRando = false;

            if (RandShrines == 1 || ((r1.Next() % 2 == 1) && RandShrines == 2))
                shrineRando = true;

            if (RandCaves == 1 || ((r1.Next() % 2 == 1) && RandCaves == 2))
                caveRando = true;

            if (RandTowns == 1 || ((r1.Next() % 2 == 1) && RandTowns == 2))
                townRando = true;

            if (shrineRando)
            {
                locIslands[4] = randoCont(ref r1, 5);
                locIslands[27] = randoCont(ref r1, 5);
                locIslands[28] = randoCont(ref r1, 5);
                locIslands[30] = randoCont(ref r1, 5);
                locIslands[31] = randoCont(ref r1, 4);
                locIslands[36] = randoCont(ref r1, 5);
                locIslands[37] = randoCont(ref r1, 5);
                locIslands[38] = randoCont(ref r1, 5);
                locIslands[39] = randoCont(ref r1, 5);
            }

            if (caveRando)
            {
                if (shrineRando == false)
                    for (int lni = 0; lni < 9; lni++)
                        r1.Next();

                locIslands[46] = randoCont(ref r1, 4);
                locIslands[47] = randoCont(ref r1, 4);
                locIslands[52] = randoCont(ref r1, 3);
                locIslands[53] = randoCont(ref r1, 5);
                locIslands[55] = randoCont(ref r1, 5);
                locIslands[59] = randoCont(ref r1, 4);
                locIslands[61] = randoCont(ref r1, 4);
                locIslands[62] = randoCont(ref r1, 5);
                locIslands[63] = randoCont(ref r1, 4);
            }

            if (townRando)
            {
                if (shrineRando == false)
                    for (int lni = 0; lni < 9; lni++)
                        r1.Next();
                if (caveRando)
                    for (int lni = 0; lni < 9; lni++)
                        r1.Next();

                locIslands[1] = randoCont(ref r1, 5);
                locIslands[2] = randoCont(ref r1, 5);
                locIslands[6] = randoCont(ref r1, 5);
                locIslands[10] = randoCont(ref r1, 4);
                locIslands[11] = randoCont(ref r1, 5);
                locIslands[12] = randoCont(ref r1, 5);
                locIslands[14] = randoCont(ref r1, 3);
                locIslands[19] = randoCont(ref r1, 5);
                locIslands[20] = randoCont(ref r1, 4);
                locIslands[21] = randoCont(ref r1, 5);
                locIslands[22] = randoCont(ref r1, 5);
                locIslands[23] = randoCont(ref r1, 5);
                locIslands[24] = randoCont(ref r1, 5);
                locIslands[25] = randoCont(ref r1, 5);
                locIslands[35] = randoCont(ref r1, 5);
                locIslands[51] = randoCont(ref r1, 5);
                locIslands[66] = randoCont(ref r1, 4);
                locIslands[70] = randoCont(ref r1, 5);
                locIslands[71] = randoCont(ref r1, 5);
            }

            if (debugmode)
            {
                using (StreamWriter writer2 = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "locIsands_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    for (int lnQ = 0; lnQ < locIslands.Count; lnQ++)
                        writer2.WriteLine(locIslands[lnQ]);
            }

            //            int[] landLocs = { 0, 1, 9, 10, 11, 12, 14, 20, 27, 30, 43, 44, 45, 46, 47, 48, 58, 59, 60, 61, 63, 65, 66, 67 };
            int[] landLocs = { 0, 9, 10, 44, 45, 48, 58, 60, 65, 67 };

            int[] returnLocs = { 0, 1, 2, 6, 7, 9, 10, 11, 12, 14,
                                 15, 16, 17, 18, 20, 23, 25, 26, 51, 65 };

            int[] returnPoints = { 0, 2, 12, -1, -1, -1, 13, 15, -1, 1, 7, 4, 5, -1, 8, 10,
                                 17, 19, 16, -1, 3, -1, -1, 11, -1, 14, 18, -1, -1, -1, -1, -1,
                                 -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                 -1, -1, -1, 9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
                                 -1, 6, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            if (debugmode)
            {
                using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                    writer2.WriteLine("Before Loop");
            }

            for (int lnI = 0; lnI < locTypes.Length; lnI++)
            {
                if (debugmode)
                {
                    using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                        writer2.WriteLine("Enter For Loop");
                }

                //if (locIslands[lnI] < 0) continue;
                int x = 300;
                int y = 300;

                //                if (lnI == 0) { x = midenX[1]; y = midenY[1]; }
                //                else if (lnI == 48) { x = midenX[0]; y = midenY[0]; } // Norud Cave East
                //                else if (lnI == 68) { x = midenX[2]; y = midenY[2]; } // Shrine South Of Romaly
                //                else if (lnI == 7) { x = midenX[6]; y = midenY[6]; } // Brecconary/Tantegel
                //                else if (locIslands[lnI] == -1 || locIslands[lnI] == -2)
                if (locIslands[lnI] == -1 || locIslands[lnI] == -2)
                {
                    // Subtract 3 for room
                    x = 4 + r1.Next() % (smallMap ? 80 - 4 - 4 : 132 - 4 - 4);
                    y = 4 + r1.Next() % (smallMap ? 80 - 4 - 4 : 132 - 4 - 4);
                }
                else if (locIslands[lnI] == -100)
                {
                    continue;
                }
                else
                {
                    // Subtract 6 for room
                    x = 6 + r1.Next() % (smallMap ? 128 - 6 - 6 : 256 - 6 - 6);
                    y = 6 + r1.Next() % (smallMap ? 128 - 6 - 6 : 256 - 6 - 6);
                }

                if (locIslands[lnI] == 6)
                {
                    if (Math.Abs(y - charlockY) < 5 || Math.Abs(x - charlockX) < 5)
                    {
                        lnI--;
                        continue;
                    }
                }

                // TODO:  Ship return points, human return points, bird return points
                // If branches on locTypes, possibly a case.
                if (debugmode)
                {
                    using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                        writer2.WriteLine(lnI + " " + x + " " + y + " " + locIslands[lnI]);
                }
                int maxX = 0;
                int maxY = 0;

                switch (locTypes[lnI])
                {
                    case "C":
                        if (debugmode)
                        {
                            using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "loop_" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                                writer2.WriteLine(validPlot(ref map, ref map2, ref island, smallMap, y, x, 2, 4, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                                    reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                                    maxLake2 : maxLake, locIslands[lnI] == 6));
                        }
                        maxX = 2;
                        maxY = 2;
                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxX, maxY, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y + 0, x + 1] = 0xe8;
                                map2[y + 0, x + 2] = 0xe9;
                                map2[y + 1, x + 1] = 0xec;
                                map2[y + 1, x + 2] = 0xed;
                            }
                            else
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y + 0, x + 1] = 0xe8;
                                    map[y + 0, x + 2] = 0xe9;
                                    map[y + 1, x + 1] = 0xec;
                                    map[y + 1, x + 2] = 0xed;
                                }
                            }

                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX) || locIslands[lnI] == 6)
                            {
                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x + 1);
                                romData[byteToUse + 1] = (byte)(y + 1);

                                if (lnI == 0) // Aliahan Castle
                                {
                                    romData[0x18535] = (byte)(x + 1);
                                    romData[0x18536] = (byte)(y + 1);
                                }

                                if (returnPoints[lnI] != -1)
                                {
                                    int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                    romData[byteToUseReturn] = (byte)(x + 1);
                                    if (locIslands[lnI] == 6)
                                    {
                                        if (map2[y + 2, x] == 0x00 || map2[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 2);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    }
                                    else
                                    {
                                        if (map[y + 2, x] == 0x00 || map[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 2);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                    }
                                    if (locIslands[lnI] != 6)
                                        shipPlacement(ref romData, ref map, ref island, byteToUseReturn + 2, y + 1, x + 1, maxLake);
                                    else
                                        shipPlacement2(ref romData, ref map2, ref island2, byteToUseReturn + 2, y + 1, x + 1, maxLake2);
                                }
                                if (locIslands[lnI] != 6)
                                {
                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                            }
                            else
                                lnI--;
                        }
                        else
                            lnI--;

                        break;
                    case "T": // Town
                        maxX = 4;
                        maxY = 1;
                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y, x] = 0x05;
                                map2[y, x + 1] = 0xea;
                                map2[y, x + 2] = 0xeb;
                                map2[y, x + 3] = 0x05;
                            }
                            else
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y, x] = 0x05;
                                    map[y, x + 1] = 0xea;
                                    map[y, x + 2] = 0xeb;
                                    map[y, x + 3] = 0x05;
                                }
                            }

                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX) || locIslands[lnI] == 6)
                            {
                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x + 1);
                                romData[byteToUse + 1] = (byte)(y);

                                if (returnPoints[lnI] != -1)
                                {
                                    int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                    romData[byteToUseReturn] = (byte)(x + 1);
                                    if (locIslands[lnI] == 6)
                                    {
                                        if (map2[y + 2, x] == 0x00 || map2[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 0);
                                    }
                                    else
                                    {
                                        if (map[y + 2, x] == 0x00 || map[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 0);
                                    }
                                    if (locIslands[lnI] != 6)
                                        shipPlacement(ref romData, ref map, ref island, byteToUseReturn + 2, y, x + 1, maxLake);
                                    else
                                        shipPlacement2(ref romData, ref map2, ref island2, byteToUseReturn + 2, y, x + 1, maxLake2);
                                }
                                if (locIslands[lnI] != 6)
                                {
                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                            }
                            else
                                lnI--;
                        }
                        else
                            lnI--;

                        break;
                    case "S": // Shrine
                        maxX = 1;
                        maxY = 2;
                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y, x] = 0xf5;
                                map2[y + 1, x] = 0x05;
                            }
                            else
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y, x] = 0xf5;
                                    map[y + 1, x] = 0x05;
                                }
                            }

                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX) || locIslands[lnI] == 6)
                            {
                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)x;
                                romData[byteToUse + 1] = (byte)y;

                                if (lnI == 28)
                                {
                                    romData[0x1851a] = (byte)x;
                                    romData[0x1851b] = (byte)y;
                                }
                                else if (lnI == 31)
                                {
                                    romData[0x184ff] = (byte)x;
                                    romData[0x18500] = (byte)y;
                                }
                                else if (lnI == 33)
                                {
                                    romData[0x18505] = romData[0x18508] = (byte)x;
                                    romData[0x18506] = romData[0x18509] = (byte)y;
                                }
                                else if (lnI == 36)
                                {
                                    romData[0x184f6] = (byte)x;
                                    romData[0x184f7] = (byte)y;
                                }
                                else if (lnI == 37)
                                {
                                    romData[0x3255d] = (byte)x;
                                    romData[0x32561] = (byte)y;
                                }
                                else if (lnI == 38)
                                {
                                    romData[0x184f9] = romData[0x1850e] = (byte)x;
                                    romData[0x184fa] = romData[0x1850f] = (byte)y;
                                }
                                else if (lnI == 39)
                                {
                                    romData[0x184fc] = romData[0x18502] = romData[0x18517] = (byte)x;
                                    romData[0x184fd] = romData[0x18503] = romData[0x18518] = (byte)y;
                                }
                                if (locIslands[lnI] != 6)
                                {
                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                            }
                            else
                                lnI--;
                        }
                        else
                            lnI--;

                        break;
                    case "V": // Village
                        maxX = 3;
                        maxY = 1;
                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y, x] = 0x05;
                                map2[y, x + 1] = 0xf1;
                                map2[y, x + 2] = 0x05;
                            }
                            else
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y, x] = 0x05;
                                    map[y, x + 1] = 0xf1;
                                    map[y, x + 2] = 0x05;
                                }
                            }

                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX) || locIslands[lnI] == 6)
                            {
                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x + 1);
                                romData[byteToUse + 1] = (byte)y;

                                if (returnPoints[lnI] != -1)
                                {
                                    int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                    romData[byteToUseReturn] = (byte)(x + 1);
                                    if (locIslands[lnI] == 6)
                                    {
                                        if (map2[y + 2, x] == 0x00 || map2[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 0);
                                    }
                                    else
                                    {
                                        if (map[y + 2, x] == 0x00 || map[y + 2, x] == 0x06)
                                            romData[byteToUseReturn + 1] = (byte)(y + 1);
                                        else
                                            romData[byteToUseReturn + 1] = (byte)(y + 0);
                                    }
                                    if (locIslands[lnI] != 6)
                                        shipPlacement(ref romData, ref map, ref island, byteToUseReturn + 2, y, x + 1, maxLake);
                                    else
                                        shipPlacement2(ref romData, ref map2, ref island2, byteToUseReturn + 2, y, x + 1, maxLake2);
                                }

                                if (lnI == 23)
                                {
                                    romData[0x311c4] = (byte)(x + 1);
                                    romData[0x311c8] = (byte)y;
                                }
                                if (locIslands[lnI] != 6)
                                {
                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                            }
                        }
                        else
                            lnI--;

                        break;
                    case "P": // Pyramid
                        maxX = 1;
                        maxY = 3;

                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                            {
                                map[y, x] = 0x01;
                                map[y + 1, x] = 0x01;
                                map[y + 2, x] = 0xf3;

                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x);
                                romData[byteToUse + 1] = (byte)(y + 2);
                                writeRandoMap(ref maplocs, y, x, maxY, maxX);
                            }
                            else
                                lnI--;
                        }
                        else
                            lnI--;

                        break;
                    case "E": // Cave
                        maxX = 1;
                        maxY = 2;
                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                map2[y, x] = 0xef;
                                map2[y + 1, x] = 0x05;
                            }
                            else
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                    map[y, x] = 0xef;
                            }

                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX) || locIslands[lnI] == 6)
                            {
                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x);
                                romData[byteToUse + 1] = (byte)(y);

                                if (lnI == 45)
                                {
                                    romData[0x18533] = (byte)(x);
                                    romData[0x18534] = (byte)(y);
                                }
                                else if (lnI == 47)
                                {
                                    romData[0x1852b] = (byte)(x);
                                    romData[0x1852c] = (byte)(y);
                                }
                                else if (lnI == 48)
                                {
                                    romData[0x1852d] = (byte)(x);
                                    romData[0x1852e] = (byte)(y);
                                }
                                else if (lnI == 49)
                                {
                                    romData[0x1853d] = (byte)(x);
                                    romData[0x1853e] = (byte)(y);
                                }
                                else if (lnI == 56)
                                {
                                    romData[0x30edb] = (byte)(x);
                                    romData[0x30edf] = (byte)(y);
                                }
                                if (locIslands[lnI] != 6)
                                {
                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                            }
                            else
                                lnI--;
                        }
                        else
                            lnI--;

                        break;
                    case "W": // Tower
                        maxX = 3;
                        maxY = 3;
                        if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                            reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                            maxLake2 : maxLake, locIslands[lnI] == 6))
                        {
                            if (locIslands[lnI] == 6)
                            {
                                for (int lnQ = 0; lnQ < maxY; lnQ++)
                                {
                                    map2[y + lnQ, x] = 0x05;
                                    map2[y + lnQ, x + 2] = 0x05;
                                }
                                map2[y, x + 1] = 0x05;
                                map2[y + 1, x + 1] = 0xf2;
                                map2[y + 2, x + 1] = 0xee;
                            }
                            else
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    for (int lnQ = 0; lnQ < maxY; lnQ++)
                                    {
                                        map[y + lnQ, x] = 0x05;
                                        map[y + lnQ, x + 2] = 0x05;
                                    }
                                    map[y, x + 1] = 0x05;
                                    map[y + 1, x + 1] = 0xf2;
                                    map[y + 2, x + 1] = 0xee;
                                }
                            }

                            if (checkRandoMap(ref maplocs, y, x, maxY, maxX) || locIslands[lnI] == 6)
                            {
                                int byteToUse = 0x1b252 + (5 * lnI);
                                romData[byteToUse] = (byte)(x + 1);
                                romData[byteToUse + 1] = (byte)(y + 2);

                                if (lnI == 60) // Najimi Tower
                                {
                                    romData[0x18537] = (byte)(x + 1);
                                    romData[0x18538] = (byte)(y + 2);

                                    // Direct LDA of Tower fall point
                                    romData[0x3d401] = (byte)(x + 1);
                                    romData[0x3d405] = (byte)(y + 2);

                                    romData[0x7d401] = (byte)(x + 1);
                                    romData[0x7d405] = (byte)(y + 2);
                                }
                                else if (lnI == 61) // Garuna Tower
                                {
                                    romData[0x1851d] = romData[0x18520] = romData[0x18526] = romData[0x18529] = (byte)(x + 1);
                                    romData[0x1851e] = romData[0x18521] = romData[0x18527] = romData[0x1852a] = (byte)(y + 2);
                                }
                                if (locIslands[lnI] != 6)
                                {
                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                            }
                            else
                                lnI--;
                        }
                        else
                            lnI--;

                        break;
                    case "?":
                        if (lnI == 3) // Baramos Castle
                        {
                            bool baramosLegal = true;
                            maxX = 6;
                            maxY = 6;

                            if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 3 ? new int[] { maxIsland[locIslands[lnI]] } : locIslands[lnI] <= 6 ? new int[] { 60000 } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], locIslands[lnI] == 6 ? 
                                maxLake2 : maxLake, locIslands[lnI] == 6))
                            {
                                for (int lnJ = x; lnJ < x + maxX; lnJ++)
                                    for (int lnK = y; lnK < y + maxY; lnK++)
                                    {
                                        if (map[lnK, lnJ] > 0x07)
                                            baramosLegal = false;
                                        if (lnK == midenY[0] && lnJ == midenX[0])
                                            baramosLegal = false;
                                        if (lnK == midenY[1] && lnJ == midenX[1])
                                            baramosLegal = false;
                                        if (lnK == midenY[2] && lnJ == midenX[2])
                                            baramosLegal = false;
                                    }

                                if (baramosLegal)
                                {
                                    if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                    {
                                        bool rmMount = false;
                                        if (BaramosCast == 1 || ((r1.Next() % 2 == 1) && BaramosCast == 2))
                                            rmMount = true;
                                        if (DisAlefGlitch == 1 || ((r1.Next() % 2 == 1) && DisAlefGlitch == 2))
                                            disAlefgardGlitch = true;
                                        if (disAlefgardGlitch)
                                        {
                                            // draw mountains
                                            for (int lnJ = 0; lnJ < 6; lnJ++)
                                                for (int lnK = 0; lnK < 6; lnK++)
                                                    island[y + lnJ, x + lnK] = 4001;
                                            if (rmMount)
                                            {
                                                for (int lnJ = 0; lnJ < 4; lnJ++)
                                                {
                                                    map[y, x + lnJ] = 0x05;
                                                    map[y + 5, x + lnJ] = 0x05;
                                                }
                                                map[y + 1, x] = 0x05;
                                                map[y + 2, x] = 0x05;
                                                map[y + 3, x] = 0x05;
                                                map[y + 4, x] = 0x05;
                                                map[y, x + 4] = 0x05;
                                                map[y, x + 5] = 0x05;
                                                map[y + 4, x + 4] = 0x05;
                                                map[y + 1, x + 5] = 0x05;
                                                map[y - 2, x + 5] = 0x05;
                                                map[y + 3, x + 5] = 0x05;
                                            }
                                            else
                                            {
                                                for (int lnJ = 0; lnJ < 4; lnJ++)
                                                {
                                                    map[y, x + lnJ] = 0x06;
                                                    map[y + 5, x + lnJ] = 0x06;
                                                }
                                                map[y + 1, x] = 0x06;
                                                map[y + 2, x] = 0x06;
                                                map[y + 3, x] = 0x06;
                                                map[y + 4, x] = 0x06;
                                                map[y, x + 4] = 0x06;
                                                map[y, x + 5] = 0x06;
                                                map[y + 4, x + 4] = 0x06;
                                                map[y + 1, x + 5] = 0x06;
                                                map[y + 2, x + 5] = 0x06;
                                                map[y + 3, x + 5] = 0x06;
                                            }
                                            // draw grass
                                            for (int lnj = 1; lnj < 4; lnj++)
                                            {
                                                map[y + 1, x + lnj] = 0x02;
                                                map[y + lnj, x + 4] = 0x02;
                                                map[y + 4, x + lnj] = 0x02;
                                            }
                                            map[y + 2, x + 1] = 0x02;
                                            map[y + 2, x + 2] = 0x02;
                                            map[y + 4, x + 5] = 0x02;
                                            map[y + 5, x + 4] = 0x02;
                                            // draw castle
                                            map[y + 2, x + 2] = 0xe8;
                                            map[y + 2, x + 3] = 0xe9;
                                            map[y + 3, x + 2] = 0xec;
                                            map[y + 3, x + 3] = 0xed;
                                            // Let's also get the Pit Of Giaga!
                                            map[y + 5, x + 5] = 0xf4;
                                            romData[0x1b3f1] = (byte)(x + 5);
                                            romData[0x1b3f2] = (byte)(y + 5);

                                            int byteToUse = 0x1b252 + (5 * 3);
                                            romData[byteToUse] = (byte)(x + 2);
                                            romData[byteToUse + 1] = (byte)(y + 3);

                                        }
                                        else
                                        {
                                            for (int lnJ = 0; lnJ < 6; lnJ++)
                                                for (int lnK = 0; lnK < 6; lnK++)
                                                    island[y + lnJ, x + lnK] = 4001;

                                            if (rmMount)
                                            {
                                                for (int lnJ = 0; lnJ < 6; lnJ++)
                                                {
                                                    map[y + lnJ, x] = 0x05;
                                                    map[y + lnJ, x + 5] = 0x05;
                                                    map[y, x + lnJ] = 0x05;
                                                    map[y + 5, x + lnJ] = 0x05;
                                                }
                                            }
                                            else
                                            {
                                                for (int lnJ = 0; lnJ < 6; lnJ++)
                                                {
                                                    map[y + lnJ, x] = 0x06;
                                                    map[y + lnJ, x + 5] = 0x06;
                                                    map[y, x + lnJ] = 0x06;
                                                    map[y + 5, x + lnJ] = 0x06;
                                                }
                                            }
                                            for (int lnJ = 1; lnJ < 5; lnJ++)
                                            {
                                                map[y + lnJ, x + 1] = 0x02;
                                                map[y + lnJ, x + 4] = 0x02;
                                                map[y + 1, x + lnJ] = 0x02;
                                                map[y + 4, x + lnJ] = 0x02;
                                            }

                                            map[y + 2, x + 2] = 0xe8;
                                            map[y + 2, x + 3] = 0xe9;
                                            map[y + 3, x + 2] = 0xec;
                                            map[y + 3, x + 3] = 0xed;

                                            // Let's also get the Pit Of Giaga!
                                            map[y + 4, x + 4] = 0xf4;
                                            romData[0x1b3f1] = (byte)(x + 4);
                                            romData[0x1b3f2] = (byte)(y + 4);

                                            int byteToUse = 0x1b252 + (5 * 3);
                                            romData[byteToUse] = (byte)(x + 2);
                                            romData[byteToUse + 1] = (byte)(y + 3);
                                        }
                                        writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                    }
                                    else
                                        lnI--;
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 8) // Charlock Castle
                        {
                            bool charlockLegal = true;
                            if (x < 10 || y < 10 || x > 150 || y > 130)
                                charlockLegal = false;

                            if (charlockLegal)
                            {
                                for (int lnJ = x; lnJ < x + 10; lnJ++)
                                    for (int lnK = y; lnK < y + 10; lnK++)
                                    {
                                        if (map2[lnK, lnJ] > 0x07)
                                            charlockLegal = false;
                                    }
                            }

                            if (charlockLegal)
                            {
                                bool landBridge = false;
                                if (Charlock == 1 || ((r1.Next() % 2 == 1) && Charlock == 2))
                                    landBridge = true;
                                charlockX = x;
                                charlockY = y;

                                for (int lnJ = 0; lnJ < 10; lnJ++)
                                    for (int lnK = 0; lnK < 10; lnK++)
                                        map2[y + lnJ, x + lnK] = 0x02;

                                for (int lnJ = 1; lnJ < 9; lnJ++)
                                    for (int lnK = 1; lnK < 9; lnK++)
                                        if (landBridge)
                                        {
                                            map2[y + lnJ, x + lnK] = 0x05;
                                        }
                                        else
                                        {
                                            map2[y + lnJ, x + lnK] = 0x06;
                                        }

                                for (int lnJ = 2; lnJ < 8; lnJ++)
                                    for (int lnK = 2; lnK < 8; lnK++)
                                        if (landBridge)
                                        {
                                            map2[y + lnJ, x + lnK] = 0x02;
                                        }
                                        else
                                        {
                                            map2[y + lnJ, x + lnK] = 0x00;
                                        }


                                for (int lnJ = 3; lnJ < 7; lnJ++)
                                    for (int lnK = 3; lnK < 7; lnK++)
                                        map2[y + lnJ, x + lnK] = 0x07;

                                map2[y + 4, x + 4] = 0xe8;
                                map2[y + 4, x + 5] = 0xe9;
                                map2[y + 5, x + 4] = 0xec;
                                map2[y + 5, x + 5] = 0xed;
                                map2[y + 5, x + 8] = 0x01;
                                int lnL = x + 9;
                                while (map2[y + 5, lnL] == 0x00 && lnL < 132)
                                {
                                    map2[y, lnL] = 0x01;
                                    lnL++;
                                }

                                // Rainbow Drop
                                romData[0x1bfc6] = (byte)(x + 8);
                                romData[0x1bfcc] = (byte)(y + 5);
                                romData[0x3f023] = (byte)(x + 6);
                                romData[0x3f027] = (byte)(x + 9);
                                romData[0x3f019] = (byte)(y + 5);

                                int byteToUse = 0x1b252 + (5 * 8);
                                romData[byteToUse] = (byte)(x + 4);
                                romData[byteToUse + 1] = (byte)(y + 5);
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 10)
                        {
                            // Portoga Shrines share the same Y coordinate
                            // Portoga weird, does not follow same creation convention as other islands, etc.
                            //

                            int shrineX = x;
                            int shrineY = y;
                            int maxShrineX = 1;
                            int maxShrineY = 2;

                            int islandX = 8 + r1.Next() % (smallMap ? 128 - 8 - 4 : 256 - 8 - 8);
                            int islandY = y;
                            int maxIslandX = 8;
                            int maxIslandY = 5;

                            if (validPlot(ref map, ref map2, ref island, smallMap, shrineY, shrineX, maxShrineY, maxShrineX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : 
                                midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                bool portogaLegal = true;

                                for (int lnJ = islandX; lnJ < islandX + maxIslandX; lnJ++)
                                    for (int lnK = islandY - 1; lnK < islandY + maxIslandY; lnK++)
                                    {
                                        if (map[lnK, lnJ] != 0x00 || island[lnK, lnJ] != maxLake)
                                            portogaLegal = false;
                                    }

                                if (portogaLegal)
                                {
                                    if (checkRandoMap(ref maplocs, islandY, islandX, maxIslandY, maxIslandX))
                                    {
                                        // Draw Portoga Shrine East to Map
                                        map[shrineY, shrineX] = 0xf5;
                                        map[shrineY + 1, shrineX] = 0x01;

                                        // Allocate Island to 3000
                                        for (int lnJ = islandX; lnJ == islandX + maxIslandX; lnJ++)
                                            for (int lnK = islandY; lnK == islandY + maxIslandY; lnK++)
                                                island[lnK, lnJ] = 3000;

                                        // Draw Portoga Island to Map
                                        int byteToUse = 0x1b252 + (5 * lnI);
                                        map[islandY, islandX] = 0x00;
                                        map[islandY, islandX + 5] = 0x05;
                                        map[islandY, islandX + 4] = 0x05;
                                        map[islandY, islandX + 3] = 0x05;
                                        map[islandY, islandX + 2] = 0x05;
                                        map[islandY, islandX + 1] = 0x05;
                                        map[islandY, islandX] = 0x00;
                                        map[islandY + 1, islandX + 7] = 0x00;
                                        map[islandY + 1, islandX + 5] = 0x05;
                                        map[islandY + 1, islandX + 4] = 0xeb;
                                        map[islandY + 1, islandX + 3] = 0xea;
                                        map[islandY + 1, islandX + 2] = 0x00;
                                        map[islandY + 1, islandX + 1] = 0x05;
                                        map[islandY + 1, islandX] = 0x00;
                                        map[islandY + 2, islandX + 7] = 0x00;
                                        map[islandY + 2, islandX + 6] = 0x00;
                                        map[islandY + 2, islandX + 5] = 0x05;
                                        map[islandY + 2, islandX + 4] = 0x05;
                                        map[islandY + 2, islandX + 3] = 0x05;
                                        map[islandY + 2, islandX + 2] = 0x00;
                                        map[islandY + 2, islandX + 1] = 0x05;
                                        map[islandY + 2, islandX] = 0x00;
                                        map[islandY + 3, islandX + 7] = 0x00;
                                        map[islandY + 3, islandX + 6] = 0x00;
                                        map[islandY + 3, islandX + 5] = 0x00;
                                        map[islandY + 3, islandX + 4] = 0x00;
                                        map[islandY + 3, islandX + 3] = 0x00;
                                        map[islandY + 3, islandX + 2] = 0x00;
                                        map[islandY + 3, islandX + 1] = 0x00;
                                        map[islandY + 3, islandX] = 0x00;

                                        // Map Portoga Town to the ROM
                                        byteToUse = 0x1b252 + (5 * 10);
                                        romData[byteToUse] = (byte)(islandX + 3);
                                        romData[byteToUse + 1] = (byte)(islandY + 1);

                                        // Draw Portoga Shrine West to the Map
                                        map[islandY, islandX + 6] = 0xf5;

                                        // Map Portoga Shrine East to the ROM
                                        byteToUse = 0x1b252 + (5 * 43);
                                        romData[byteToUse] = (byte)shrineX;
                                        romData[byteToUse + 1] = (byte)shrineY;
                                        romData[0x1850b] = romData[0x3d18b] = romData[0x7d18b] = (byte)shrineX;
                                        romData[0x1850c] = romData[0x3d181] = romData[0x7d181] = (byte)shrineY;

                                        // Map Portoga Shrine West to the ROM
                                        byteToUse = 0x1b252 + (5 * 44);
                                        romData[byteToUse] = (byte)(islandX + 6);
                                        romData[byteToUse + 1] = (byte)(islandY);
                                        romData[0x3d192] = romData[0x7d192] = (byte)(islandX + 6);

                                        // Write Portoga return point and ship placement
                                        int byteToUseReturn = 0x1b61c + (4 * returnPoints[10]);
                                        romData[byteToUseReturn] = (byte)(islandX + 5);
                                        romData[byteToUseReturn + 1] = (byte)(islandY + 2);
                                        shipPlacement(ref romData, ref map, ref island, byteToUseReturn + 2, islandY + 2, islandX + 2, maxLake);

                                        romData[0x3d126] = romData[0x7d126] = romData[byteToUseReturn + 2];
                                        romData[0x3d12a] = romData[0x7d12a] = romData[byteToUseReturn + 3];

                                        writeRandoMap(ref maplocs, shrineY, shrineX, maxShrineY, maxShrineX);
                                        writeRandoMap(ref maplocs, islandY - 1, islandX, maxIslandY, maxIslandX); // -1 accounts for north water that is needed to generate Portoga
                                    }
                                    else
                                        lnI--;
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 15) // Lancel / Lancel Cave
                        {
                            bool lancelLegal = true;
                            maxX = 5;
                            maxY = 3;

                            for (int lnJ = x; lnJ < x + maxX; lnJ++)
                                for (int lnK = y; lnK < y + maxY; lnK++)
                                {
                                    if (map[lnK, lnJ] > 0x07)
                                        lancelLegal = false;
                                }

                            if (lancelLegal)
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    bool rmMount = false;
                                    if (LancelCave == 1 || ((r1.Next() % 2 == 1) && LancelCave == 2))
                                        rmMount = true;
                                    for (int lnJ = 0; lnJ < maxX; lnJ++)
                                    {
                                        if (rmMount)
                                        {
                                            map[y, x + lnJ] = 0x02;
                                            map[y + 2, x + lnJ] = 0x02;
                                        }
                                        else
                                        {
                                            map[y, x + lnJ] = 0x06;
                                            map[y + 2, x + lnJ] = 0x06;
                                        }
                                        island[y, x + lnJ] = 6000;
                                        island[y + 1, x + lnJ] = 6000;
                                        island[y + 2, x + lnJ] = 6000;
                                    }

                                    if (rmMount)
                                        map[y + 1, x] = 0x01;
                                    else
                                        map[y + 1, x] = 0x06;
                                    map[y + 1, x + 1] = 0xef;
                                    map[y + 1, x + 2] = 0x02;
                                    map[y + 1, x + 3] = 0xea;
                                    map[y + 1, x + 4] = 0xeb;
                                    map[y, x + 3] = 0x02;
                                    map[y, x + 4] = 0x02;
                                    map[y + 2, x + 3] = 0x02;
                                    map[y + 2, x + 4] = 0x02;
                                    map[y + 1, x + 5] = 0x02;
                                    map[y, x + 5] = 0x02;
                                    map[y + 2, x + 5] = 0x02;

                                    romData[0x1b360] = (byte)(x + 1);
                                    romData[0x1b361] = (byte)(y + 1);

                                    romData[0x1b29d] = (byte)(x + 3);
                                    romData[0x1b29e] = (byte)(y + 1);

                                    romData[0x3d16f] = (byte)(x + 2);

                                    romData[0x32736] = (byte)(x + 3);
                                    romData[0x3273a] = (byte)(y + 1);

                                    // Return point
                                    int byteToUseReturn = 0x1b61c + (4 * 10);
                                    romData[byteToUseReturn] = (byte)(x + 4);
                                    romData[byteToUseReturn + 1] = (byte)(y + 2);
                                    shipPlacement(ref romData, ref map, ref island, byteToUseReturn + 2, y + 2, x + 4, maxLake);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 29) // Olivia Canal Shrine
                        {
                            maxX = 8;
                            maxY = 3;

                            bool oliviaLegal = true;
                            for (int lnJ = x; lnJ < x + maxX; lnJ++)
                                for (int lnK = y; lnK < y + maxY; lnK++)
                                {
                                    if (map[lnK, lnJ] != 0x00 || island[lnK, lnJ] != maxLake)
                                        oliviaLegal = false;
                                }

                            if (oliviaLegal)
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    // Create line of mountains
                                    for (int lnJ = 1; lnJ < 5; lnJ++)
                                    {
                                        map[y + 2, x + lnJ] = 0x06;
                                        map[y, x + lnJ] = 0x06;
                                    }
                                    // Make the rest water
                                    for (int lnJ = 5; lnJ < 8; lnJ++)
                                    {
                                        map[y + 2, x + lnJ] = 0x00;
                                        map[y + 1, x + lnJ] = 0x00;
                                        map[y, x + lnJ] = 0x00;
                                    }
                                    map[y + 1, x] = 0x06;
                                    map[y + 1, x + 1] = 0xf5; // Shrine Placement
                                    map[y + 1, x + 7] = 0xf7; // Shoal Placement

                                    romData[0x1b2e3] = (byte)(x + 1);
                                    romData[0x1b2e4] = (byte)(y + 1);
                                    // Olivia bad news spot
                                    romData[0x3313e] = (byte)(x + 2);
                                    romData[0x33144] = (byte)(y + 1);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 32) // Silver Orb Shrine; skip, addressing that in Necrogund.
                            continue;
                        else if (lnI == 35) // Dragon Queen Castle
                        {
                            maxX = 6;
                            maxY = 6;

                            if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    bool rmMount = false;
                                    if (DrgQnCast == 1 || ((r1.Next() % 2 == 1) && DrgQnCast == 2))
                                        rmMount = true;
                                    if (rmMount)
                                    {
                                        map[y, x + 2] = 0x05;
                                        map[y, x + 3] = 0x05;
                                        map[y + 1, x + 1] = 0x05;
                                        map[y + 1, x + 4] = 0x05;
                                        map[y + 2, x] = 0x05;
                                        map[y + 2, x + 5] = 0x05;
                                        map[y + 3, x] = 0x05;
                                        map[y + 3, x + 5] = 0x05;
                                        map[y + 4, x + 1] = 0x05;
                                        map[y + 4, x + 4] = 0x05;
                                        map[y + 5, x + 2] = 0x05;
                                        map[y + 5, x + 3] = 0x05;
                                    }
                                    else
                                    {
                                        map[y, x + 2] = 0x06;
                                        map[y, x + 3] = 0x06;
                                        map[y + 1, x + 1] = 0x06;
                                        map[y + 1, x + 4] = 0x06;
                                        map[y + 2, x] = 0x06;
                                        map[y + 2, x + 5] = 0x06;
                                        map[y + 3, x] = 0x06;
                                        map[y + 3, x + 5] = 0x06;
                                        map[y + 4, x + 1] = 0x06;
                                        map[y + 4, x + 4] = 0x06;
                                        map[y + 5, x + 2] = 0x06;
                                        map[y + 5, x + 3] = 0x06;
                                    }
                                    map[y + 1, x + 2] = 0x02;
                                    map[y + 1, x + 3] = 0x02;
                                    map[y + 2, x + 1] = 0x02;
                                    map[y + 2, x + 4] = 0x02;
                                    map[y + 3, x + 1] = 0x02;
                                    map[y + 3, x + 4] = 0x02;
                                    map[y + 4, x + 2] = 0x02;
                                    map[y + 4, x + 3] = 0x02;
                                    map[y + 2, x + 2] = 0xe8;
                                    map[y + 2, x + 3] = 0xe9;
                                    map[y + 3, x + 2] = 0xec;
                                    map[y + 3, x + 3] = 0xed;

                                    int byteToUse = 0x1b252 + (5 * lnI);
                                    romData[byteToUse] = (byte)(x + 2);
                                    romData[byteToUse + 1] = (byte)(y + 3);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;

                        }
                        else if (lnI == 44)
                            continue;
                        else if (lnI == 49) // Necrogund F1
                        {
                            maxX = 10;
                            maxY = 6;

                            bool necrogondLegal = true;
                            for (int lnJ = x; lnJ < x + maxX; lnJ++)
                                for (int lnK = y; lnK < y + maxY; lnK++)
                                {
                                    if (map[lnK, lnJ] > 0x07)
                                        necrogondLegal = false;
                                }

                            if (necrogondLegal)
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    bool rmMount = false;
                                    if (CaveOfNecro == 1 || ((r1.Next() % 2 == 1) && CaveOfNecro == 2))
                                        rmMount = true;
                                    for (int lnJ = x; lnJ < x + maxX; lnJ++)
                                        for (int lnK = y; lnK < y + maxY; lnK++)
                                        {
                                            island[lnK, lnJ] = 5001;
                                        }

                                    for (int lnJ = y + 1; lnJ < y + maxY; lnJ++)
                                    {
                                        if (rmMount)
                                        {
                                            map[lnJ, x] = 0x05;
                                            map[lnJ, x + 7] = 0x05;
                                            map[lnJ, x + 9] = 0x05;
                                        }
                                        else
                                        {
                                            map[lnJ, x] = 0x06;
                                            map[lnJ, x + 7] = 0x06;
                                            map[lnJ, x + 9] = 0x06;
                                        }
                                    }
                                    for (int lnJ = x; lnJ < x + 10; lnJ++)
                                    {
                                        if (rmMount)
                                            map[y + 5, lnJ] = 0x05;
                                        else
                                            map[y + 5, lnJ] = 0x06;
                                    }
                                    for (int lnJ = x; lnJ < x + 10; lnJ++)
                                        map[y, lnJ] = 0x05;

                                    // Silver Orb Shrine/Necrogond F5
                                    map[y + 1, x + 8] = 0x06;
                                    map[y + 2, x + 8] = 0xf5;
                                    map[y + 3, x + 8] = 0x05;
                                    map[y + 4, x + 8] = 0xef;

                                    // The rest
                                    map[y + 1, x + 1] = 0x05;
                                    map[y + 1, x + 2] = 0x05;
                                    map[y + 1, x + 3] = 0x05;
                                    map[y + 1, x + 4] = 0x06;
                                    map[y + 1, x + 5] = 0x05;
                                    map[y + 1, x + 6] = 0x06;

                                    map[y + 2, x + 1] = 0x05;
                                    map[y + 2, x + 2] = 0x05;
                                    map[y + 2, x + 3] = 0x00;
                                    map[y + 2, x + 4] = 0x05;
                                    map[y + 2, x + 5] = 0xf0;
                                    map[y + 2, x + 6] = 0x05;

                                    map[y + 3, x + 1] = 0x05;
                                    map[y + 3, x + 2] = 0x00;
                                    map[y + 3, x + 3] = 0x00;
                                    map[y + 3, x + 4] = 0x05;
                                    map[y + 3, x + 5] = 0x05;
                                    map[y + 3, x + 6] = 0x05;

                                    map[y + 4, x + 1] = 0x00;
                                    map[y + 4, x + 2] = 0x00;
                                    map[y + 4, x + 3] = 0x05;
                                    map[y + 4, x + 4] = 0x05;
                                    map[y + 4, x + 5] = 0x05;
                                    map[y + 4, x + 6] = 0xef;

                                    // Volcano stuff
                                    // First, Sword of Gaia
                                    romData[0x2e7f] = romData[0x32a93] = (byte)(x + 5);
                                    romData[0x2e85] = romData[0x32a99] = (byte)(y + 1);
                                    // Second, mapping stuff
                                    romData[0x3f09b] = (byte)(x + 1);
                                    romData[0x3f09f] = (byte)(x + 4);
                                    romData[0x3f0a5] = (byte)(y + 2);
                                    romData[0x3f0a9] = (byte)(y + 6);
                                    // Map link to cave now though!
                                    // Beginning
                                    romData[0x18531] = romData[0x1b34c] = (byte)(x + 6);
                                    romData[0x18532] = romData[0x1b34d] = (byte)(y + 4);
                                    // End
                                    romData[0x1852f] = romData[0x1b347] = (byte)(x + 8);
                                    romData[0x18530] = romData[0x1b348] = (byte)(y + 4);
                                    // Shrine
                                    romData[0x1b2f2] = (byte)(x + 8);
                                    romData[0x1b2f3] = (byte)(y + 2);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 50) // Necrogrund F5/Silver Orb Shrine - skip, see above
                            continue;
                        else if (lnI == 65) // Grass tile south of Reeve
                        {
                            maxX = 3;
                            maxY = 3;

                            if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y, x] = 0x04;
                                    map[y, x + 1] = 0x04;
                                    map[y, x + 2] = 0x04;
                                    map[y + 1, x] = 0x04;
                                    map[y + 1, x + 2] = 0x04;
                                    map[y + 2, x] = 0x04;
                                    map[y + 2, x + 1] = 0x04;
                                    map[y + 2, x + 2] = 0x04;
                                    map[y + 1, x + 1] = 0x03;

                                    romData[0x1b3df] = (byte)(x + 1);
                                    romData[0x1b3e0] = (byte)(y + 1);

                                    romData[0x184f3] = romData[0x18539] = (byte)(x + 1);
                                    romData[0x184f4] = romData[0x1853a] = (byte)(y + 1);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 66) // Isis
                        {
                            maxX = 5;
                            maxY = 4;

                            if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y, x + 1] = 0x04;
                                    map[y, x + 2] = 0x04;
                                    map[y + 1, x] = 0x04;
                                    map[y + 1, x + 3] = 0x04;
                                    map[y + 2, x] = 0x04;
                                    map[y + 2, x + 1] = 0x04;
                                    map[y + 2, x + 4] = 0x04;
                                    map[y + 3, x + 1] = 0x04;
                                    map[y + 3, x + 2] = 0x04;
                                    map[y + 3, x + 3] = 0x04;
                                    map[y + 1, x + 1] = 0x00;
                                    map[y + 1, x + 2] = 0x00;
                                    map[y + 2, x + 2] = 0x00;
                                    map[y + 2, x + 3] = 0x00;

                                    romData[0x1b39d] = (byte)(x + 1);
                                    romData[0x1b39e] = (byte)(y + 3);

                                    romData[0x1b3bb] = (byte)(x + 1);
                                    romData[0x1b3bc] = (byte)(y + 2);

                                    romData[0x1b3b5] = (byte)(x + 0);
                                    romData[0x1b3b6] = (byte)(y + 1);

                                    romData[0x1b3af] = (byte)(x + 1);
                                    romData[0x1b3b0] = (byte)(y + 0);

                                    romData[0x1b3a9] = (byte)(x + 2);
                                    romData[0x1b3aa] = (byte)(y + 0);

                                    romData[0x1b3c1] = (byte)(x + 3);
                                    romData[0x1b3c2] = (byte)(y + 2);

                                    romData[0x1b3a3] = (byte)(x + 3);
                                    romData[0x1b3a4] = (byte)(y + 3);

                                    if (returnPoints[lnI] != -1)
                                    {
                                        int byteToUseReturn = 0x1b61c + (4 * returnPoints[lnI]);
                                        romData[byteToUseReturn] = (byte)(x);
                                        romData[byteToUseReturn + 1] = (byte)(y + 1);
                                        shipPlacement(ref romData, ref map, ref island, byteToUseReturn + 2, y + 1, x, maxLake);

                                    }

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 67) // Enticement Cave
                        {
                            maxX = 3;
                            maxY = 3;

                            if (smallMap)
                            {
                                if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                    reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                    midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                                {
                                    if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                    {
                                        for (int lnX = 0; lnX < 3; lnX++)
                                            for (int lnY = 0; lnY < 3; lnY++)
                                                map[y + lnY, x + lnX] = 0x04;

                                        map[y + 1, x + 1] = 0x00;

                                        romData[0x1b3e5] = (byte)(x + 1);
                                        romData[0x1b3e6] = (byte)(y + 2);

                                        romData[0x18514] = romData[0x1853b] = (byte)(x + 1);
                                        romData[0x18515] = romData[0x1853c] = (byte)(y + 2);

                                        writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                    }
                                    else
                                        lnI--;
                                }
                                else
                                    lnI--;
                            }
                            else
                            {
                                maxX = 5;
                                maxY = 5;

                                if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                    reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                                {
                                    if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                    {
                                        for (int lnX = 0; lnX < 5; lnX++)
                                            for (int lnY = 0; lnY < 5; lnY++)
                                                map[y + lnY, x + lnX] = 0x05;

                                        for (int lnX = 1; lnX < 4; lnX++)
                                            for (int lnY = 1; lnY < 4; lnY++)
                                                map[y + lnY, x + lnX] = 0x04;

                                        map[y + 2, x + 2] = 0x00;
                                        map[y + 4, x + 2] = 0x04;

                                        romData[0x1b3e5] = (byte)(x + 2);
                                        romData[0x1b3e6] = (byte)(y + 3);

                                        romData[0x18514] = romData[0x1853b] = (byte)(x + 2);
                                        romData[0x18515] = romData[0x1853c] = (byte)(y + 3);

                                        writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                    }
                                    else
                                        lnI--;
                                }
                                else
                                    lnI--;
                            }
                        }
                        else if (lnI == 68) // Shrine South of Romaly
                        {
                            maxX = 1;
                            maxY = 1;

                            if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    romData[0x1b3d9] = (byte)(x);
                                    romData[0x1b3da] = (byte)(y);

                                    romData[0x18523] = (byte)(x);
                                    romData[0x18524] = (byte)(y);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;

                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 69) // Pirate Ship
                        {
                            bool baramosLegal = true;
                            if (map[y, x] != 0x00 || island[y, x] != maxLake)
                                baramosLegal = false;

                            if (baramosLegal)
                            {
                                romData[0x378ba] = romData[0x3b630] = (byte)x;
                                romData[0x378be] = romData[0x3b634] = (byte)y;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 70) // Greenland house
                        {
                            maxX = 3;
                            maxY = 3;

                            if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                            {
                                if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                {
                                    map[y + 0, x + 0] = 0x01;
                                    map[y + 0, x + 1] = 0x01;
                                    map[y + 0, x + 2] = 0x01;
                                    map[y + 1, x + 0] = 0x01;
                                    map[y + 1, x + 2] = 0x01;
                                    map[y + 2, x + 0] = 0x01;
                                    map[y + 2, x + 1] = 0x01;
                                    map[y + 2, x + 2] = 0x01;
                                    map[y + 1, x + 1] = 0x02;

                                    romData[0x1b3d3] = (byte)(x + 1);
                                    romData[0x1b3d4] = (byte)(y + 1);

                                    writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                }
                                else
                                    lnI--;
                            }
                            else
                                lnI--;
                        }
                        else if (lnI == 71) // New Town
                        {
                            maxX = 3;
                            maxY = 3;

                            bool remNewTown = false;
                            if (NoNewTown == 1 || ((r1.Next() % 2 == 0) && NoNewTown == 2))
                                remNewTown = true;

                            if (remNewTown == false)
                            {
                                if (validPlot(ref map, ref map2, ref island, smallMap, y, x, maxY, maxX, (locIslands[lnI] <= 6 ? new int[] { maxIsland[locIslands[lnI]] } : islands.ToArray())) && 
                                    reachable(ref map, ref island, ref map2, ref island2, y, x, !landLocs.Contains(lnI), locIslands[lnI] <= 6 ? midenX[locIslands[lnI]] : midenX[1], locIslands[lnI] <= 6 ? 
                                    midenY[locIslands[lnI]] : midenY[1], maxLake, locIslands[lnI] == 6))
                                {
                                    if (checkRandoMap(ref maplocs, y, x, maxY, maxX))
                                    {
                                        map[y + 0, x + 0] = 0x04;
                                        map[y + 0, x + 1] = 0x04;
                                        map[y + 0, x + 2] = 0x04;
                                        map[y + 1, x + 0] = 0x04;
                                        map[y + 1, x + 2] = 0x04;
                                        map[y + 2, x + 0] = 0x04;
                                        map[y + 2, x + 1] = 0x04;
                                        map[y + 2, x + 2] = 0x04;
                                        map[y + 1, x + 1] = 0x02;

                                        romData[0x1b397] = (byte)(x + 1);
                                        romData[0x1b398] = (byte)(y + 1);

                                        writeRandoMap(ref maplocs, y, x, maxY, maxX);
                                    }
                                    else
                                        lnI--;
                                }
                                else
                                    lnI--;
                            }
                        }
                        break;
                    case "X":
                        continue;
                }
            }

            List<int> part1 = new List<int>() { 4, 5, 6, 7 };
            List<int> part2 = new List<int>() { 8, 9, 10, 12, 13, 14 };
            List<int> part3 = new List<int>() { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 26, 27, 28, 29, 30, 31, 32, 33, 35, 36, 37, 39, 41, 42, 43, 44, 45, 46, 47, 48, 49 };
            List<int> tantegel = new List<int>() { 50, 51, 52, 54, 55, 57, 58, 60, 61, 63 };

            int[,] monsterZones = new int[16, 16];
            for (int lnI = 0; lnI < 16; lnI++)
                for (int lnJ = 0; lnJ < 16; lnJ++)
                    monsterZones[lnI, lnJ] = 0xff;

            int midenMZX = midenX[1] / 16;
            int midenMZY = midenY[1] / 16;

            for (int mzX = 0; mzX < 16; mzX++)
                for (int mzY = 0; mzY < 16; mzY++)
                {
                    //					if (mzX == 10) mzX = mzX; // Why redeclare?
                    if (zone[mzY, mzX] / 1000 == 1)
                    {
                        if (Math.Abs(midenMZX - mzX) == 0 && Math.Abs(midenMZY - mzY) == 0)
                            monsterZones[mzY, mzX] = 4;
                        else
                            monsterZones[mzY, mzX] = part1[r1.Next() % part1.Count];
                    }
                    else if (zone[mzY, mzX] / 1000 == 2)
                        monsterZones[mzY, mzX] = part2[r1.Next() % part2.Count];
                    else
                        monsterZones[mzY, mzX] = part3[r1.Next() % part3.Count];

                    monsterZones[mzY, mzX] += 64 * (r1.Next() % 4);
                }

            bool badMap = true;
            bool compressed = false;
            while (badMap)
            {
                // Now let's enter all of this into the ROM...
                int lnPointer = 0x821a;

                for (int lnI = 0; lnI <= 256; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map.
                {
                    romData[0x14028 + (lnI * 2)] = (byte)(lnPointer % 256);
                    romData[0x14029 + (lnI * 2)] = (byte)(lnPointer / 256);

                    int lnJ = 0;

                    while (lnI < 256 && lnJ < 256)
                    {
                        if (map[lnI, lnJ] >= 0 && map[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map[lnI, lnJ];
                            while (lnJ < 256 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            romData[lnPointer + 0xc010] = (byte)((0x20 * numberToMatch) + (tileNumber - 1));
                            lnPointer++;
                        }
                        else
                        {
                            romData[lnPointer + 0xc010] = (byte)map[lnI, lnJ];
                            lnPointer++;
                            lnJ++;
                        }
                    }

                }
                if (compressed) badMap = false;

                //lnPointer = lnPointer;
                if (lnPointer > 0x9a94)
                {
                    MessageBox.Show("WARNING:  The map1 might have taken too much ROM space... (" + (lnPointer - 0x9a94).ToString() + " over)");
                    compressed = true;
                    // Might have to compress further to remove one byte stuff
                    // Must compress the map by getting rid of further 1 byte lakes
                }
                else
                    badMap = false;
            }

            badMap = true;
            compressed = false;
            while (badMap)
            {
                // Now let's enter all of this into the ROM... (Alefgard)
                int lnPointer = 0x9bab;

                for (int lnI = 0; lnI <= 139; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map.
                {
                    romData[0x15aa5 + (lnI * 2)] = (byte)(lnPointer % 256);
                    romData[0x15aa6 + (lnI * 2)] = (byte)(lnPointer / 256);

                    int lnJ = 0;
                    while (lnI < 139 && lnJ < 158)
                    {
                        if (map2[lnI, lnJ] >= 0 && map2[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map2[lnI, lnJ];
                            while (lnJ < 158 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map2[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            romData[lnPointer + 0xc010] = (byte)((0x20 * numberToMatch) + (tileNumber - 1));
                            lnPointer++;
                        }
                        else
                        {
                            romData[lnPointer + 0xc010] = (byte)map2[lnI, lnJ];
                            lnPointer++;
                            lnJ++;
                        }
                    }
                }
                if (compressed) badMap = false;

                //lnPointer = lnPointer;
                if (lnPointer > 0xa3ee)
                {
                    MessageBox.Show("WARNING:  The map2 might have taken too much ROM space... (" + (lnPointer - 0xa3ee).ToString() + " over)");
                    compressed = true;
                    // Might have to compress further to remove one byte stuff
                    // Must compress the map by getting rid of further 1 byte lakes
                }
                else
                    badMap = false;
            }

            // Ensure monster zones are 8x8
            if (smallMap)
            {
                romData[0x2d8] = 0x85;
                romData[0x2d9] = 0x4a;
                romData[0x2da] = 0xa5;
                romData[0x2db] = 0x2b;
                romData[0x2dc] = 0x29;
                romData[0x2dd] = 0xf0;
                romData[0x2de] = 0x0a;
            }

            // Enter monster zones
            for (int lnI = 0; lnI < 16; lnI++)
                for (int lnJ = 0; lnJ < 16; lnJ++)
                {
                    if (monsterZones[lnI, lnJ] == 0xff)
                        monsterZones[lnI, lnJ] = (r1.Next() % 60) + ((r1.Next() % 4) * 64);
                    romData[0x956 + (lnI * 16) + lnJ] = (byte)monsterZones[lnI, lnJ];
                }

            if (GenIslandsMonstersZones == true)
            {
                string shortVersion1 = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "zones_" + txtSeed + "_" + txtFlags + "_" + shortVersion1 + ".txt")))
                {
                    for (int lnY = 0; lnY < 16; lnY++)
                    {
                        string output = "";
                        for (int lnX = 0; lnX < 16; lnX++)
                            output += zone[lnY, lnX].ToString().PadLeft(5) + " ";
                        writer.WriteLine(output);
                    }
                }
            }

            if (GenIslandsMonstersZones == true)
            {
                string shortVersion1 = versionNumber.Replace(".", "");
                using (StreamWriter writer = File.CreateText(Path.Combine(Path.GetDirectoryName(txtFileName), "monsters_" + txtSeed+ "_" + txtFlags + "_" + shortVersion1 + ".txt")))
                {
                    for (int lnY = 0; lnY < 16; lnY++)
                    {
                        string output = "";
                        for (int lnX = 0; lnX < 16; lnX++)
                            output += monsterZones[lnY, lnX].ToString("X2") + " ";
                        writer.WriteLine(output);
                    }
                }
            }
            if (debugmode)
            {
                for (int lnB = 0; lnB < 256; lnB++)
                    for (int lnA = 0; lnA < 256; lnA++)
                    {
                        using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "maplocs" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                            writer2.Write(maplocs[lnA, lnB]);
                        if (lnA == 255)
                        {
                            using (StreamWriter writer2 = File.AppendText(Path.Combine(Path.GetDirectoryName(txtFileName), "maplocs" + txtSeed + "_" + txtFlags + "_" + shortVersion + ".txt")))
                                writer2.WriteLine("");
                        }
                    }
            }

            //            return true;
        }

        private bool reachable(ref int[,] map, ref int[,] island, ref int[,] map2, ref int[,] island2, int startY, int startX, bool water, int finishX, int finishY, int maxLake, bool alefgard)
        {
            int x = startX;
            int y = startY;

            List<int> validPlots = new List<int> { 1, 2, 3, 4, 5, 7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xef, 0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xfb, 0xff };
            if (water) validPlots.Add(0);

            bool first = true;
            List<int> toPlot = new List<int>();

            if (alefgard)
            {
                bool[,] plotted = new bool[139, 158];

                while (first || toPlot.Count != 0)
                {
                    if (!first)
                    {
                        y = toPlot[0];
                        toPlot.RemoveAt(0);
                        x = toPlot[0];
                        toPlot.RemoveAt(0);
                    }
                    else
                    {
                        first = false;
                    }

                    for (int dir = 0; dir < 5; dir++)
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 139 ? 0 : dirY == -1 ? 138 : dirY);

                        if (validPlots.Contains(map2[dirY, dirX]) && (map2[dirY, dirX] != 0 || island2[dirY, dirX] == maxLake))
                        {
                            if (dir != 0 && plotted[dirY, dirX] == false)
                            {
                                if (finishX == dirX && finishY == dirY)
                                    return true;
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                                plotted[dirY, dirX] = true;
                            }
                        }
                    }
                }

                return false;
            }
            else
            {
                bool[,] plotted = new bool[256, 256];

                while (first || toPlot.Count != 0)
                {
                    if (!first)
                    {
                        y = toPlot[0];
                        toPlot.RemoveAt(0);
                        x = toPlot[0];
                        toPlot.RemoveAt(0);
                    }
                    else
                    {
                        first = false;
                    }

                    for (int dir = 0; dir < 5; dir++)
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

                        if (validPlots.Contains(map[dirY, dirX]) && (map[dirY, dirX] != 0 || island[dirY, dirX] == maxLake))
                        {
                            if (dir != 0 && plotted[dirY, dirX] == false)
                            {
                                if (finishX == dirX && finishY == dirY)
                                    return true;
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                                plotted[dirY, dirX] = true;
                            }
                        }
                    }
                }

                return false;
            }
        }

        private void resetIslands(ref int [,] map, ref int[,] map2, ref int[,] island, ref int[,] island2, ref int[] maxIsland, ref List<int> islands)
        {
            for (int y = 0; y < 256; y++)
                for (int x = 0; x < 256; x++)
                {
                    if (island[y, x] != 200 && island[y, x] != -1)
                    {
                        island[y, x] /= 1000;
                        island[y, x] *= 1000;
                    }
                }

            islands.Clear();

            markIslands(ref map, ref map2, ref island, ref island2, ref islands, ref maxIsland, 1000);
            markIslands(ref map, ref map2, ref island, ref island2, ref islands, ref maxIsland, 2000);
            markIslands(ref map, ref map2, ref island, ref island2, ref islands, ref maxIsland, 0);
            markIslands(ref map, ref map2, ref island, ref island2, ref islands, ref maxIsland, -1000);
        }

        private void shipPlacement(ref byte[] romData, ref int[,] map, ref int[,] island, int byteToUse, int top, int left, int maxLake = 0)
        {
            int minDirection = -99;
            int minDistance = 999;
            int finalX = 0;
            int finalY = 0;
            int distance = 0;
            int lnJ = top;
            int lnK = left;
            for (int lnI = 0; lnI < 4; lnI++)
            {
                lnJ = top;
                lnK = left;
                if (lnI == 0)
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnJ = (lnJ == 0 ? 255 : lnJ - 1);
                    }
                }
                else if (lnI == 1)
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnJ = (lnJ == 255 ? 0 : lnJ + 1);
                    }
                }
                else if (lnI == 2)
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnK = (lnK == 255 ? 0 : lnK + 1);
                    }
                }
                else
                {
                    while (island[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnK = (lnK == 0 ? 255 : lnK - 1);
                    }
                }
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minDirection = lnI;
                    finalX = lnK;
                    finalY = lnJ;
                }
                distance = 0;
            }
            romData[byteToUse] = (byte)(finalX);
            romData[byteToUse + 1] = (byte)(finalY);
            if (minDirection == 0)
            {
                lnJ = (finalY == 255 ? 0 : finalY + 1);
                while (map[lnJ, finalX] == 0x06)
                {
                    map[lnJ, finalX] = 0x05;
                    lnJ = (lnJ == 255 ? 0 : lnJ + 1);
                }
            }
            else if (minDirection == 1)
            {
                lnJ = (finalY == 0 ? 255 : finalY - 1);
                while (map[lnJ, finalX] == 0x06)
                {
                    map[lnJ, finalX] = 0x05;
                    lnJ = (lnJ == 0 ? 255 : lnJ - 1);
                }
            }
            else if (minDirection == 2)
            {
                lnK = (finalX == 0 ? 255 : finalX - 1);
                while (map[finalY, lnK] == 0x06)
                {
                    map[finalY, lnK] = 0x05;
                    lnK = (lnK == 0 ? 255 : lnK - 1);
                }
            }
            else
            {
                lnK = (finalX == 255 ? 0 : finalX + 1);
                while (map[finalY, lnK] == 0x06)
                {
                    map[finalY, lnK] = 0x05;
                    lnK = (lnK == 255 ? 0 : lnK + 1);
                }
            }
        }

        private void shipPlacement2(ref byte[] romData, ref int[,] map2, ref int[,] island2, int byteToUse, int top, int left, int maxLake = 0)
        {
            int minDirection = -99;
            int minDistance = 999;
            int finalX = 0;
            int finalY = 0;
            int distance = 0;
            int lnJ = top;
            int lnK = left;
            for (int lnI = 0; lnI < 4; lnI++)
            {
                lnJ = top;
                lnK = left;
                if (lnI == 0)
                {
                    while (island2[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnJ = (lnJ == 0 ? 138 : lnJ - 1);
                    }
                }
                else if (lnI == 1)
                {
                    while (island2[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnJ = (lnJ == 138 ? 0 : lnJ + 1);
                    }
                }
                else if (lnI == 2)
                {
                    while (island2[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnK = (lnK == 157 ? 0 : lnK + 1);
                    }
                }
                else
                {
                    while (island2[lnJ, lnK] != maxLake && distance < 200)
                    {
                        distance++;
                        lnK = (lnK == 0 ? 157 : lnK - 1);
                    }
                }
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minDirection = lnI;
                    finalX = lnK;
                    finalY = lnJ;
                }
                distance = 0;
            }
            romData[byteToUse] = (byte)(finalX);
            romData[byteToUse + 1] = (byte)(finalY);
            if (minDirection == 0)
            {
                lnJ = (finalY == 255 ? 0 : finalY + 1);
                while (map2[lnJ, finalX] == 0x06)
                {
                    map2[lnJ, finalX] = 0x05;
                    lnJ = (lnJ == 255 ? 0 : lnJ + 1);
                }
            }
            else if (minDirection == 1)
            {
                lnJ = (finalY == 0 ? 255 : finalY - 1);
                while (map2[lnJ, finalX] == 0x06)
                {
                    map2[lnJ, finalX] = 0x05;
                    lnJ = (lnJ == 0 ? 255 : lnJ - 1);
                }
            }
            else if (minDirection == 2)
            {
                lnK = (finalX == 0 ? 255 : finalX - 1);
                while (map2[finalY, lnK] == 0x06)
                {
                    map2[finalY, lnK] = 0x05;
                    lnK = (lnK == 0 ? 255 : lnK - 1);
                }
            }
            else
            {
                lnK = (finalX == 255 ? 0 : finalX + 1);
                while (map2[finalY, lnK] == 0x06)
                {
                    map2[finalY, lnK] = 0x05;
                    lnK = (lnK == 255 ? 0 : lnK + 1);
                }
            }
        }

        private void smoothMap(ref int[,] map, ref int[,] island)
        {
            // Remove one byte lands
            for (int lnX = 0; lnX < 254; lnX++)
                for (int lnY = 0; lnY < 256; lnY++)
                {
                    if (map[lnY, lnX] != map[lnY, lnX + 1] && map[lnY, lnX + 1] != map[lnY, lnX + 2] && island[lnY, lnX] == island[lnY, lnX + 2])
                    {
                        map[lnY, lnX + 1] = map[lnY, lnX];
                        island[lnY, lnX + 1] = island[lnY, lnX];
                    }
                }

            int smoothRequirement = 10;
            bool badMap = true;

            while (badMap)
            {
                // Let's PRETEND to enter this into the ROM...
                int lnPointer = 0x821a;

                for (int lnI = 0; lnI <= 256; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map.
                {
                    int lnJ = 0;
                    while (lnI < 256 && lnJ < 256)
                    {
                        if (map[lnI, lnJ] >= 0 && map[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map[lnI, lnJ];
                            while (lnJ < 256 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            lnPointer++;
                        }
                        else
                        {
                            lnPointer++;
                            lnJ++;
                        }
                    }
                }
                //lnPointer = lnPointer;
                if (lnPointer <= 0x9a94 - 320)
                    badMap = false;
                else // Time to remove small areas of stuff to hopefully compress the map further.
                {
                    //MessageBox.Show("Map too big; " + (lnPointer - (0x9a94 - 256)).ToString() + " bytes too big");

                    int lastTile = 0x00;
                    int lastIsland = island[0, 0];
                    for (int lnY = 0; lnY < 255; lnY++)
                        for (int lnX = 0; lnX < 255; lnX++)
                        {
                            smoothPlot(ref map, ref island, lnX, lnY, smoothRequirement, lastTile, lastIsland);
                            lastTile = map[lnY, lnX];
                            lastIsland = island[lnY, lnX];
                        }

                    smoothRequirement += 10;
                }
            }
        }

        private void smoothMap2(ref int[,] map2, ref int[,] island2)
        {
            // Remove one byte lands
            for (int lnX = 0; lnX < 156; lnX++)
                for (int lnY = 0; lnY < 139; lnY++)
                {
                    if (map2[lnY, lnX] != map2[lnY, lnX + 1] && map2[lnY, lnX + 1] != map2[lnY, lnX + 2] && island2[lnY, lnX] == island2[lnY, lnX + 2])
                    {
                        map2[lnY, lnX + 1] = map2[lnY, lnX];
                        island2[lnY, lnX + 1] = island2[lnY, lnX];
                    }
                }

            int smoothRequirement = 10;
            bool badMap = true;

            while (badMap)
            {
                // Let's PRETEND to enter this into the ROM...
                int lnPointer = 0x9bab;

                for (int lnI = 0; lnI <= 138; lnI++) // <---- There is a final pointer for lnI = 256, probably indicating the conclusion of the map2.
                {
                    int lnJ = 0;
                    while (lnI < 139 && lnJ < 158)
                    {
                        if (map2[lnI, lnJ] >= 0 && map2[lnI, lnJ] <= 7)
                        {
                            int tileNumber = 0;
                            int numberToMatch = map2[lnI, lnJ];
                            while (lnJ < 158 && tileNumber < (numberToMatch == 7 ? 8 : 32) && map2[lnI, lnJ] == numberToMatch)
                            {
                                tileNumber++;
                                lnJ++;
                            }
                            lnPointer++;
                        }
                        else
                        {
                            lnPointer++;
                            lnJ++;
                        }
                    }
                }
                //lnPointer = lnPointer;
                if (lnPointer <= 0xa3ee - 80)
                    badMap = false;
                else // Time to remove small areas of stuff to hopefully compress the map further.
                {
                    //MessageBox.Show("Map too big; " + (lnPointer - (0x9a94 - 256)).ToString() + " bytes too big");

                    int lastTile = 0x00;
                    int lastIsland = island2[0, 0];
                    for (int lnY = 0; lnY < 139; lnY++)
                        for (int lnX = 0; lnX < 158; lnX++)
                        {
                            smoothPlot2(ref map2, ref island2, lnX, lnY, smoothRequirement, lastTile, lastIsland);
                            lastTile = map2[lnY, lnX];
                            lastIsland = island2[lnY, lnX];
                        }

                    smoothRequirement += 10;
                }
            }

        }

        private void smoothPlot(ref int[,] map, ref int[,] island, int initX, int initY, int minimum, int fillTile, int fillIsland)
        {
            //if (y == 30 && x == 137)
            //    y = y;

            int x = initX;
            int y = initY;

            bool[,] plotted = new bool[256, 256];
            int landTile = map[y, x];

            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 0;
            int toFill = 0;
            while (toFill < 2)
            {
                while (first || toPlot.Count != 0)
                {
                    if (!first)
                    {
                        y = toPlot[0];
                        toPlot.RemoveAt(0);
                        x = toPlot[0];
                        toPlot.RemoveAt(0);
                    }
                    else
                        first = false;

                    if (toFill == 1)
                    {
                        map[y, x] = fillTile;
                        island[y, x] = fillIsland;
                    }

                    for (int dir = 0; dir < 5; dir++)
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 256 ? 0 : dirX == -1 ? 255 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 256 ? 0 : dirY == -1 ? 255 : dirY);

                        if (map[dirY, dirX] == landTile && !plotted[dirY, dirX])
                        {
                            plots++;
                            plotted[dirY, dirX] = true;

                            if (plots > minimum)
                                return;

                            if (dir != 0)
                            {
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                            }
                        }
                    }
                }

                toFill++;
                x = initX;
                y = initY;
                first = true;
            }
        }

        private void smoothPlot2(ref int [,] map2, ref int[,] island2, int initX, int initY, int minimum, int fillTile, int fillIsland)
        {
            //if (y == 30 && x == 137)
            //    y = y;

            int x = initX;
            int y = initY;

            bool[,] plotted = new bool[139, 158];
            int landTile = map2[y, x];

            bool first = true;
            List<int> toPlot = new List<int>();
            int plots = 0;
            int toFill = 0;
            while (toFill < 2)
            {
                while (first || toPlot.Count != 0)
                {
                    if (!first)
                    {
                        y = toPlot[0];
                        toPlot.RemoveAt(0);
                        x = toPlot[0];
                        toPlot.RemoveAt(0);
                    }
                    else
                        first = false;

                    if (toFill == 1)
                    {
                        map2[y, x] = fillTile;
                        island2[y, x] = fillIsland;
                    }

                    for (int dir = 0; dir < 5; dir++)
                    {
                        int dirX = (dir == 4 ? x - 1 : dir == 2 ? x + 1 : x);
                        dirX = (dirX == 158 ? 0 : dirX == -1 ? 157 : dirX);
                        int dirY = (dir == 1 ? y - 1 : dir == 3 ? y + 1 : y);
                        dirY = (dirY == 139 ? 0 : dirY == -1 ? 138 : dirY);

                        if (map2[dirY, dirX] == landTile && !plotted[dirY, dirX])
                        {
                            plots++;
                            plotted[dirY, dirX] = true;

                            if (plots > minimum)
                                return;

                            if (dir != 0)
                            {
                                toPlot.Add(dirY);
                                toPlot.Add(dirX);
                            }
                        }
                    }
                }

                toFill++;
                x = initX;
                y = initY;
                first = true;
            }
        }

        private bool validPlot(ref int[,] map, ref int[,] map2, ref int[,]island, bool smallMap, int y, int x, int height, int width, int[] legalIsland)
        {
            if (legalIsland[0] == 60000)
            {
                for (int lnI = 0; lnI < height; lnI++)
                    for (int lnJ = 0; lnJ < width; lnJ++)
                    {
                        if (y + lnI >= 137 || x + lnJ >= 156) return false;

                        int legalY = y + lnI;
                        int legalX = x + lnJ;

                        if (map2[legalY, legalX] == 0x00 || map2[legalY, legalX] == 0x06 || map2[legalY, legalX] >= 0xe8 || map[legalY, legalX] >= 0xe8) // LAST CONDITION:  Castles, towns, villages, etc - Need to not match BOTH maps!
                            return false;
                    }
            }
            else
            {
                for (int lnI = 0; lnI < height; lnI++)
                    for (int lnJ = 0; lnJ < width; lnJ++)
                    {
                        if (y + lnI >= (smallMap ? 128 : 256) || x + lnJ >= (smallMap ? 128 : 256)) return false;

                        int legalY = (y + lnI >= 256 ? y - 256 + lnI : y + lnI);
                        int legalX = (x + lnJ >= 256 ? x - 256 + lnJ : x + lnJ);

                        bool ok = false;
                        for (int lnK = 0; lnK < legalIsland.Length; lnK++)
                            if (island[legalY, legalX] == legalIsland[lnK])
                                ok = true;
                        if (!ok) return false;
                        if (legalY < 139 && legalX < 158)
                        {
                            if (map[legalY, legalX] == 0x00 || map[legalY, legalX] == 0x06 || map[legalY, legalX] >= 0xe8 || map2[legalY, legalX] >= 0xe8) // LAST CONDITION:  Castles, towns, villages, etc - Need to not match BOTH maps!
                                return false;
                        }
                        else
                        {
                            if (map[legalY, legalX] == 0x00 || map[legalY, legalX] == 0x06 || map[legalY, legalX] >= 0xe8) // LAST CONDITION:  Castles, towns, villages, etc
                                return false;
                        }
                    }
            }
            return true;
        }

        private bool validPoint(int x, int y, int zoneToUse, bool smallMap, ref int[,] zone)
        {
            if (zoneToUse == -1000) return true;
            int zoneSize = (smallMap ? 8 : 16);
            // Establish zone
            int zoneX = x / zoneSize;
            int zoneY = y / zoneSize;
            int zoneSides = zone[zoneY, zoneX] % 1000;
            //if (zone[zoneY, zoneX] % 1000 != 0) return false;
            if (zone[zoneY, zoneX] / 1000 != zoneToUse / 1000) return false;
            // 1 = north, 2 = east, 4 = south, 8 = west
            if (y % zoneSize == 0 && zoneSides % 2 == 1) return false;
            if (x % zoneSize == zoneSize - 1 && zoneSides % 4 >= 2) return false;
            if (y % zoneSize == zoneSize - 1 && zoneSides % 8 >= 4) return false;
            if (x % zoneSize == 0 && zoneSides % 16 >= 8) return false;

            return true;
        }

        private void writeRandoMap(ref int[,] maplocs, int y, int x, int maxY, int maxX)
        {
            for (int lnX = 0; lnX < maxX; lnX++)
                for (int lnY = 0; lnY < maxY; lnY++)
                    maplocs[x + lnX, y + lnY] = 1;
        }


    }
}
