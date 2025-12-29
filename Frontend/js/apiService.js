const API_BASE_URL = "http://localhost:5000/api"; // Adjust port to match your backend

// [Optimization] Async/Await for cleaner performance
export async function fetchProducts() {
    try {
        const response = await fetch(`${API_BASE_URL}/products`);
        
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        // [JSON Structure] Parsing the JSON response
        return await response.json();
    } catch (error) {
        console.error("Integration Error:", error);
        return [];
    }
}