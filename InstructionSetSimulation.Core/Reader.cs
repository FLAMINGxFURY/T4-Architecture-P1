﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core {
    public class Reader {
        private static Reader _instance = null;
        private static Object _syncLock = new Object();
        public ushort PC;           //Program Counter
        private ushort currentWord; //current data in reader
        private BinaryReader fileIn;

        private Reader() {
            PC = 0;
            currentWord = 0;
            fileIn = new BinaryReader(File.Open("../../../../test.bin", FileMode.Open)); //for now we edit the filename here and have no way to select it.

        }

        public static Reader GetInstance() {
            lock(_syncLock) {
                if(_instance == null) {
                    return new Reader();
				}
                return _instance;
			}
		}

        public ushort GetNextWord() {

            ushort ret = fileIn.ReadUInt16();

            return ret;
		}

    }
}
