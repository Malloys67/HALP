using System;
using System.Collections.Generic;
using System.Text;

namespace HALP
{
    public class Block
    {
        public int Height { get; set; }
        public Int64 Timestamp { get; set; }
        public byte[] PrevHash { get; set; }
        public byte[] Hash { get; set; }
        public Transaction[] Transactions { get; set; }
        public string Creator { get; set; }

        //Height is a sequence number of blocks.
        //TimeStamp is the time when the block was created.
        //PrevHash is a Hash of the previous block.
        //Hash is the hash of the block.The Hash can be imagined as the unique identity of the block. There are no blocks that have the same Hash.
        //Transactions are collections of transactions that occur, as previously discussed above.
        //Creator is who creates the block identified by the public key.
    }
}
