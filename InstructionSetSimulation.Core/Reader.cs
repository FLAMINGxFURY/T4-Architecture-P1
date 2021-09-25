using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core {
    public class Reader {
        private static Reader _instance = null;
        private static Object _syncLock = new Object();
        public ushort PC = 0;           //Program Counter
        private ushort currentWord = 0; //current data in reader

        private Reader() {
            //Private constructor is attribute of Singletons, idk if we need anything in here yet
		}

        public static Reader GetInstance() {
            lock(_syncLock) {
                if(_instance == null) {
                    return new Reader();
				}
                return _instance;
			}
		}

        //TODO: Implement reader here for a file - probably need more attributes up top to accomplish this
        public ushort GetNextWord() {

            ushort ret = 0;
            
            //TODO: Reader here

            return ret;
		}

    }
}
