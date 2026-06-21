SELECT u.user_id,
u.full_name,
COUNT(DISTINCT r.event_id) events_attended,
COUNT(DISTINCT f.feedback_id) feedbacks_submitted
FROM Users u
LEFT JOIN Registrations r
ON u.user_id=r.user_id
LEFT JOIN Feedback f
ON u.user_id=f.user_id
GROUP BY u.user_id,u.full_name;