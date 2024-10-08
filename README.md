# Group-2-Repo

# Chinese Postman Problem 

This project provides a Python implementation for solving the **Chinese Postman Problem (CPP)**. The goal of CPP is to find the minimum-cost route that visits every edge in a given graph at least once, making it applicable to real-world scenarios such as postal delivery or garbage collection routes.

## Features
- **Graph Input**: Supports an undirected, weighted graph where edges can be added with their respective weights.
- **Odd-Degree Vertices Matching**: Automatically identifies vertices with odd degrees and finds the minimum-cost matching to make the graph Eulerian.
- **Eulerian Tour**: Constructs the Eulerian tour that visits every edge exactly once, even accounting for duplicate edges when necessary.
- **Dijkstra's Algorithm**: Utilizes Dijkstra's algorithm to compute the shortest path between vertices.
- **Cost Calculation**: Computes the total cost of traversing the graph, including the cost of additional edges required to make the graph Eulerian.

## How It Works
1. **Input Handling**: 
    - Number of vertices (`n`) and edges (`e`) are provided as input.
    - The edges are inputted with vertex connections and their weights.
    - A start vertex for the Eulerian tour is specified.

2. **Edge Addition**: 
    - If an edge between two vertices already exists but has a higher weight, the lower-weight edge replaces it.
    - If no such edge exists, the new edge is added to the graph and the adjacency list.

3. **Degree Calculation**: 
    - The degrees of all vertices are computed to identify vertices with odd degrees.

4. **Odd-Degree Vertices Matching**: 
    - Vertices with odd degrees are matched using a minimum-cost pairing, calculated using Dijkstra’s shortest path algorithm.

5. **Eulerian Tour Construction**: 
    - After ensuring the graph is Eulerian (i.e., no vertices with odd degrees), the algorithm constructs an Eulerian tour starting from the given vertex.

6. **Cost and Route Output**: 
    - The program outputs the total cost to traverse the graph and the route (sequence of edges) that forms the Eulerian tour.

## Code Explanation

### Key Functions

- `add_edge(edge_name, u, v, weight)`: 
    - Adds an edge between vertices `u` and `v` with the given weight. If an edge between these vertices already exists with a higher weight, it replaces the old one.

- `get_degrees(adjacency_list)`: 
    - Computes the degree (number of edges) for each vertex in the graph.

- `get_odd_degree_vertices(degree)`: 
    - Identifies vertices with odd degrees, which need to be paired to make the graph Eulerian.

- `dijkstra(source, target)`: 
    - Finds the shortest path between two vertices `source` and `target` using Dijkstra's algorithm and returns both the path and the distance.

- `find_minimum_matching(odd_vertices)`: 
    - Pairs the odd-degree vertices by finding the shortest paths between them.

- `add_minimum_matching_edges(odd_vertices, pairings)`: 
    - Adds the minimum-cost edges found during the matching process to ensure all vertices have even degrees.

- `find_eulerian_tour(start_vertex)`: 
    - Constructs the Eulerian tour from the starting vertex by traversing the graph.

- `solve_cpp()`: 
    - The main function that orchestrates the steps to solve the Chinese Postman Problem.

## How to Run
1. Ensure you have Python installed on your machine.
2. Clone the repository or download the script.
3. Run the script and provide the required input values for vertices and edges.
4. Follow the prompts to see the total cost and the route for the Eulerian tour.

