SELECT u.full_name,
COUNT(f.feedback_id) total_feedbacks
FROM Users u
JOIN Feedback f
ON u.user_id=f.user_id
GROUP BY u.user_id,u.full_name
ORDER BY total_feedbacks DESC
LIMIT 5;