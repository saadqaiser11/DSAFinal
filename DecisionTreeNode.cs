using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance
{
    public class DecisionTreeNode
    {
        public string Question { get; set; }
        public string CareerRecommendation { get; set; }
        public Dictionary<string, DecisionTreeNode> Children { get; set; }

        public DecisionTreeNode(string content)
        {
            if (content.Contains("Do you") || content.Contains("?"))
            {
                Question = content;
            }
            else
            {
                CareerRecommendation = content;
            }
            Children = new Dictionary<string, DecisionTreeNode>();
        }
    }

}
