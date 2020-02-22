""" Node is defined as
class node:
  def __init__(self, data):
      self.data = data
      self.left = None
      self.right = None
"""
def check_binary_search_tree_(root):
    return is_BST(root.left, -1, root.data) and is_BST(root.right, root.data, 10001)

def is_BST(current_node, min_data, max_data):
    if current_node == None:
        return True
    
    if current_node.data >= max_data or current_node.data <= min_data:
        return False
    
    return is_BST(current_node.left, min_data, current_node.data) and is_BST(current_node.right, current_node.data, max_data)
