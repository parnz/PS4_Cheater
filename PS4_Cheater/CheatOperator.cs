using System;
using System.Linq;

namespace PS4_Cheater
{
    public class CheatOperator
    {
        public CheatOperator(ValueType valueType, ProcessManager processManager)
        {
            ProcessManager = processManager;
            ValueType = valueType;
        }

        private ValueType _valueType;

        protected MemoryHelper MemoryHelper = new MemoryHelper(true, 0);

        public ProcessManager ProcessManager { get; set; }

        public ValueType ValueType
        {
            get
            {
                return _valueType;
            }
            set
            {
                _valueType = value;
                MemoryHelper.InitMemoryHandler(ValueType, CompareType.NONE, false);
            }
        }
        public CheatOperatorType CheatOperatorType { get; set; }

        public virtual byte[] Get(int idx = 0) { return null; }

        public virtual byte[] GetRuntime() { return null; }

        public virtual void Set(CheatOperator SourceCheatOperator, int idx = 0) { }

        public virtual void SetRuntime(CheatOperator SourceCheatOperator, int idx = 0) { }

        public virtual int GetSectionID() { return -1; }

        public virtual bool Parse(string[] cheat_elements, ref int start_idx, bool simple_format) { return false; }

        public virtual string ToString(bool simple) { return null; }

        public virtual string Dump(bool simpleFormat) { return null; }

        public virtual string Display() { return null; }
    }
}
