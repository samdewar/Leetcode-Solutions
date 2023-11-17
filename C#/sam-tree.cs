// https://leetcode.com/problems/same-tree/ Completed
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p==q) return true;
        try{
        if(p.val!=q.val) return false; 
        }catch(Exception e){
            return false;
        }
        // RIGHT
        if(p.right!=null && q.right!=null){
            if(!IsSameTree(p.right,q.right)) return false;
            
        }else if(p.right!=null || q.right!=null){
        
            return false;            
        }
        
        // LEFT
        if(p.left!=null && q.left!=null){
            if(!IsSameTree(p.left,q.left)) return false;
        
        }else if(p.left!=null || q.left!=null){
        
            return false;
        }

        
     return true;   
    }
    
}