import { fetchProducts } from './apiService.js';

const productList = document.getElementById('product-list');
const loadBtn = document.getElementById('load-products-btn');

// [Optimization] Simple function to render UI efficiently
function renderProducts(products) {
    productList.innerHTML = ''; // Clear current list
    
    if (products.length === 0) {
        productList.innerHTML = '<li>No products found or connection failed.</li>';
        return;
    }

    // Creating HTML dynamically based on JSON
    products.forEach(product => {
        const li = document.createElement('li');
        li.textContent = `${product.name} - $${product.price} (Stock: ${product.stock})`;
        productList.appendChild(li);
    });
}

loadBtn.addEventListener('click', async () => {
    loadBtn.textContent = "Loading...";
    loadBtn.disabled = true;

    // Call the service
    const data = await fetchProducts();
    
    renderProducts(data);
    
    loadBtn.textContent = "Refresh Products";
    loadBtn.disabled = false;
});